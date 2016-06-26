﻿using EyesOfTheDragon.XRpgLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using EyesOfTheDragon.XRpgLibrary.TileEngine;
using Microsoft.Xna.Framework.Graphics;
using EyesOfTheDragon.Components;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using Microsoft.Xna.Framework.Input;
using EyesOfTheDragon.XRpgLibrary.WorldClasses;

namespace EyesOfTheDragon.GameScreens
{
    public class GamePlayScreen : BaseGameState
    {
        #region Field Region
        Engine engine = new Engine(32, 32);
        static Player player;
        static World world;
        #endregion

        #region Property Region
        public static World World
        {
            get { return world; }
            set { world = value; }
        }
        public static Player Player
        {
            get { return player; }
            set { player = value; }
        }
        #endregion

        #region Constructor Region
        public GamePlayScreen(EyesOfTheDragon game, GameStateManager manager) : base(game, manager)
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
        }
        public override void Update(GameTime gameTime)
        {
            world.Update(gameTime);
            player.Update(gameTime);

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, player.Camera.Transformation);

            world.DrawLevel(GameRef.SpriteBatch, player.Camera);
            player.Draw(gameTime, GameRef.SpriteBatch);

            base.Draw(gameTime);
            GameRef.SpriteBatch.End();
        }
        #endregion
        #region Abstract Method Region
        #endregion
    }
}