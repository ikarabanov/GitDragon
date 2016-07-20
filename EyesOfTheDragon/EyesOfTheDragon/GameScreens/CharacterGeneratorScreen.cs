﻿using EyesOfTheDragon.XRpgLibrary;
using EyesOfTheDragon.XRpgLibrary.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using EyesOfTheDragon.Components;
using EyesOfTheDragon.XRpgLibrary.TileEngine;
using EyesOfTheDragon.XRpgLibrary.WorldClasses;
using EyesOfTheDragon.XRpgLibrary.ItemClasses;
using EyesOfTheDragon.XRpgLibrary.ItemClassesX;
using System.IO;
using EyesOfTheDragon.XRpgLibrary.CharacterClasses;
using EyesOfTheDragon.XRpgLibrary.CharacterClassesX;

namespace EyesOfTheDragon.GameScreens
{
    public class CharacterGeneratorScreen : BaseGameState
    {
        #region Field Region
        LeftRightSelector genderSelector;
        LeftRightSelector classSelector;
        PictureBox backgroundImage;
        PictureBox characterImage;

        string[] genderItems = { "Male", "Female" };
        //string[] classItems = { "Fighter", "Wizard", "Rogue", "Priest" };
        string[] classItems;
        Texture2D[,] characterImages;
        Texture2D containers;
        #endregion

        #region Property Region
        public string SelectedGender
        {
            get { return genderSelector.SelectedItem; }
        }
        public string SelectedClass
        {
            get { return classSelector.SelectedItem; }
        }
        #endregion

        #region Constructor Region
        public CharacterGeneratorScreen(EyesOfTheDragon game, GameStateManager stateManager) : base(game,stateManager)
        {
        }
        #endregion

        #region XNA Method Region
        public override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            base.LoadContent();

            classItems = new string[DataManager.EntityData.Count];
            int counter = 0;

            foreach (string className in DataManager.EntityData.Keys)
            {
                classItems[counter] = className;
                counter++;
            }

            LoadImages();
            CreateControls();
            containers = Game.Content.Load<Texture2D>(@"ObjectSprites\containers");

        }
        public override void Update(GameTime gameTime)
        {
            ControlManager.Update(gameTime, PlayerIndex.One);
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin();
            base.Draw(gameTime);
            ControlManager.Draw(GameRef.SpriteBatch);
            GameRef.SpriteBatch.End();
        }
        #endregion

        #region Method Region
        private void CreateControls()
        {
            Texture2D leftTexture = Game.Content.Load<Texture2D>(@"GUI\leftarrowUp");
            Texture2D rightTexture = Game.Content.Load<Texture2D>(@"GUI\rightarrowUp");
            Texture2D stopTexture = Game.Content.Load<Texture2D>(@"GUI\StopBar");

            backgroundImage = new PictureBox(Game.Content.Load<Texture2D>(@"Backgrounds\titlescreen"), GameRef.ScreenRectangle);
            ControlManager.Add(backgroundImage);

            Label label1 = new Label();

            label1.Text = "Who will search for the Eyes of the Dragon?";
            label1.Size = label1.SpriteFont.MeasureString(label1.Text);
            label1.Position = new Vector2((GameRef.Window.ClientBounds.Width - label1.Size.X) / 2, 150);

            ControlManager.Add(label1);

            genderSelector = new LeftRightSelector(leftTexture, rightTexture, stopTexture);
            genderSelector.SetItems(genderItems, 125);
            genderSelector.Position = new Vector2(label1.Position.X, 200);
            genderSelector.SelectionChanged += new EventHandler(selectionChanged);

            ControlManager.Add(genderSelector);

            classSelector = new LeftRightSelector(leftTexture, rightTexture, stopTexture);
            classSelector.SetItems(classItems, 125);
            classSelector.Position = new Vector2(label1.Position.X, 250);
            classSelector.SelectionChanged += selectionChanged;

            ControlManager.Add(classSelector);

            LinkLabel linkLabel1 = new LinkLabel();
            linkLabel1.Text = "Accept this character.";
            linkLabel1.Position = new Vector2(label1.Position.X, 300);
            linkLabel1.Selected += new EventHandler(linkLabel1_Selected);

            ControlManager.Add(linkLabel1);

            characterImage = new PictureBox(characterImages[0, 0], new Rectangle(500, 200, 96, 96), new Rectangle(0, 0, 32, 32));
            ControlManager.Add(characterImage);

            ControlManager.NextControl();
        }
        private void LoadImages()
        {
            characterImages = new Texture2D[genderItems.Length, classItems.Length];

            for (int i = 0; i < genderItems.Length; i++)
            {
                for (int j = 0; j < classItems.Length; j++)
                {
                    characterImages[i, j] = Game.Content.Load<Texture2D>(@"PlayerSprites\" + genderItems[i] + classItems[j]);
                }
            }
        }

        void selectionChanged(object sender, EventArgs e)
        {
            characterImage.Image = characterImages[genderSelector.SelectedIndex, classSelector.SelectedIndex];
        }
        void linkLabel1_Selected(object sender, EventArgs e)
        {
            InputHandler.Flush();

            CreatePlayer();
            CreateWorld();

            GameRef.SkillScreen.SkillPoints = 25;
            StateManager.ChangeState(GameRef.SkillScreen);
        }
        public void CreatePlayer()
        {
            //Texture2D spriteSheet = Game.Content.Load<Texture2D>(@"PlayerSprites\" + GameRef.CharacterGeneratorScreen.SelectedGender + GameRef.CharacterGeneratorScreen.SelectedClass);
            Dictionary<AnimationKey, Animation> animations = new Dictionary<AnimationKey, Animation>();

            Animation animation = new Animation(3, 32, 32, 0, 0);
            animations.Add(AnimationKey.Down, animation);

            animation = new Animation(3, 32, 32, 0, 32);
            animations.Add(AnimationKey.Left, animation);

            animation = new Animation(3, 32, 32, 0, 64);
            animations.Add(AnimationKey.Right, animation);

            animation = new Animation(3, 32, 32, 0, 96);
            animations.Add(AnimationKey.Up, animation);

            AnimatedSprite sprite = new AnimatedSprite(
                    characterImages[genderSelector.SelectedIndex, classSelector.SelectedIndex],
                    animations);
            EntityGender gender = EntityGender.Male;

            if (genderSelector.SelectedIndex == 1)
                gender = EntityGender.Female;

            Entity entity = new Entity("Pat", DataManager.EntityData[classSelector.SelectedItem], gender, EntityType.Character);

            Character character = new Character(entity, sprite);

            GamePlayScreen.Player = new Player(GameRef, character);
        }
        public void CreateWorld()
        {
            Texture2D tilesetTexture = Game.Content.Load<Texture2D>(@"Tilesets\tileset1");
            Tileset tileset1 = new Tileset(tilesetTexture, 8, 8, 32, 32);

            tilesetTexture = Game.Content.Load<Texture2D>(@"Tilesets\tileset2");
            Tileset tileset2 = new Tileset(tilesetTexture, 8, 8, 32, 32);

            List<Tileset> tilesets = new List<Tileset>();
            tilesets.Add(tileset1);
            tilesets.Add(tileset2);

            MapLayer layer = new MapLayer(100, 100);

            for (int y = 0; y < layer.Height; y++)
            {
                for (int x = 0; x < layer.Width; x++)
                {
                    Tile tile = new Tile(0, 0);

                    layer.SetTile(x, y, tile);
                }
            }

            MapLayer splatter = new MapLayer(100, 100);
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(0, 100);
                int y = random.Next(0, 100);
                int index = random.Next(2, 14);

                Tile tile = new Tile(index, 0);
                splatter.SetTile(x, y, tile);
            }

            splatter.SetTile(1, 0, new Tile(0, 1));
            splatter.SetTile(2, 0, new Tile(2, 1));
            splatter.SetTile(3, 0, new Tile(0, 1));

            List<MapLayer> mapLayers = new List<MapLayer>();
            mapLayers.Add(layer);
            mapLayers.Add(splatter);

            TileMap map = new TileMap(tilesets, mapLayers);
            Level level = new Level(map);

            ChestData chestData = new ChestData();
            chestData.Name = "Some Chest";
            chestData.MinGold = 10;
            chestData.MaxGold = 101;
            Chest chest = new Chest(chestData);
            BaseSprite chestSprite = new BaseSprite(containers, new Rectangle(0, 0, 32, 32), new Point(10, 10));
            ItemSprite itemSprite = new ItemSprite(chest, chestSprite);
            level.Chests.Add(itemSprite);

            //Look at Form Details ReadChestData to enter chests into item manager and then load it on screen.
            // ChestData chestDate2 = Game.Content.Load<ChestData>(@"Game\Chests\Plain Chest");
            string[] fileName = Directory.GetFiles(@"Content\Game\Chests\", "*.xml");
            ChestData chestData2 = XnaSerializer.XnaSerializer.Deserialize<ChestData>(fileName[0]);
            Chest chest2 = new Chest(chestData2);

            Console.WriteLine(chestData2.ToString());

            BaseSprite chestSprite2 = new BaseSprite(containers, new Rectangle(0, 0, 32, 32), new Point(5, 5));

            ItemSprite itemSprite2 = new ItemSprite(chest2, chestSprite2);
            level.Chests.Add(itemSprite2);



            World world = new World(GameRef, GameRef.ScreenRectangle);
            world.Levels.Add(level);
            world.CurrentLevel = 0;

            GamePlayScreen.World = world;
        }
        #endregion
    }
}
