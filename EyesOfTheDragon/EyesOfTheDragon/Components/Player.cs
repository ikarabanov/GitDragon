using EyesOfTheDragon.XRpgLibrary;
using EyesOfTheDragon.XRpgLibrary.CharacterClassesX;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using EyesOfTheDragon.XRpgLibrary.TileEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.Components
{
    public class Player
    {
        #region Field Region
        Camera camera;
        EyesOfTheDragon gameRef;
        readonly Character character;
        #endregion

        #region Property Region
        public Camera Camera
        {
            get { return camera; }
            set { camera = value; }
        }
        public AnimatedSprite Sprite
        {
            get { return character.Sprite; }
        }
        public Character Character
        {
            get { return character; }
        }
        #endregion

        #region Constructor Region
        public Player (EyesOfTheDragon game, Character character)
        {
            gameRef = (EyesOfTheDragon)game;
            camera = new Camera(gameRef.ScreenRectangle);
            this.character = character;
        }
        #endregion

        #region Method Region
        public void Update(GameTime gameTime)
        {
            camera.Update(gameTime);
            Sprite.Update(gameTime);

            if (InputHandler.KeyReleased(Keys.PageUp))
            {
                camera.ZoomIn();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(Sprite);
            }
            else if (InputHandler.KeyReleased(Keys.PageDown))
            {
                camera.ZoomOut();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(Sprite);
            }

            Vector2 motion = new Vector2();

            if (InputHandler.KeyDown(Keys.W))
            {
                Sprite.CurrentAnimation = AnimationKey.Up;
                motion.Y = -1;
            }
            else if (InputHandler.KeyDown(Keys.S))
            {
                Sprite.CurrentAnimation = AnimationKey.Down;
                motion.Y = 1;
            }
            if (InputHandler.KeyDown(Keys.A))
            {
                Sprite.CurrentAnimation = AnimationKey.Left;
                motion.X = -1;
            }
            else if (InputHandler.KeyDown(Keys.D))
            {
                Sprite.CurrentAnimation = AnimationKey.Right;
                motion.X = 1;
            }

            if (motion != Vector2.Zero)
            {
                Sprite.IsAnimating = true;
                motion.Normalize();

                Sprite.Position += motion * Sprite.Speed;
                Sprite.LockToMap();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(Sprite);
            }
            else
            {
                Sprite.IsAnimating = false;
            }

            if (InputHandler.KeyReleased(Keys.F))
            {
                camera.ToggleCameraMode();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(Sprite);
            }

            if (camera.CameraMode != CameraMode.Follow)
            {
                if (InputHandler.KeyReleased(Keys.C))
                    camera.LockToSprite(Sprite);
            }

        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            character.Draw(gameTime, spriteBatch);
        }
        #endregion
    }
}
