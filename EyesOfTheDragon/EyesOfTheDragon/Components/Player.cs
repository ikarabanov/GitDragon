using EyesOfTheDragon.XRpgLibrary;
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
        readonly AnimatedSprite sprite;
        #endregion

        #region Property Region
        public Camera Camera
        {
            get { return camera; }
            set { camera = value; }
        }
        public AnimatedSprite Sprite
        {
            get { return sprite; }
        }
        #endregion

        #region Constructor Region
        public Player (EyesOfTheDragon game, AnimatedSprite sprite)
        {
            gameRef = (EyesOfTheDragon)game;
            camera = new Camera(gameRef.ScreenRectangle);
            this.sprite = sprite;
        }
        #endregion

        #region Method Region
        public void Update(GameTime gameTime)
        {
            camera.Update(gameTime);
            sprite.Update(gameTime);

            if (InputHandler.KeyReleased(Keys.PageUp))
            {
                camera.ZoomIn();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(sprite);
            }
            else if (InputHandler.KeyReleased(Keys.PageDown))
            {
                camera.ZoomOut();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(sprite);
            }

            Vector2 motion = new Vector2();

            if (InputHandler.KeyDown(Keys.W))
            {
                sprite.CurrentAnimation = AnimationKey.Up;
                motion.Y = -1;
            }
            else if (InputHandler.KeyDown(Keys.S))
            {
                sprite.CurrentAnimation = AnimationKey.Down;
                motion.Y = 1;
            }
            if (InputHandler.KeyDown(Keys.A))
            {
                sprite.CurrentAnimation = AnimationKey.Left;
                motion.X = -1;
            }
            else if (InputHandler.KeyDown(Keys.D))
            {
                sprite.CurrentAnimation = AnimationKey.Right;
                motion.X = 1;
            }

            if (motion != Vector2.Zero)
            {
                sprite.IsAnimating = true;
                motion.Normalize();

                sprite.Position += motion * sprite.Speed;
                sprite.LockToMap();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(sprite);
            }
            else
            {
                sprite.IsAnimating = false;
            }

            if (InputHandler.KeyReleased(Keys.F))
            {
                camera.ToggleCameraMode();
                if (camera.CameraMode == CameraMode.Follow)
                    camera.LockToSprite(sprite);
            }

            if (camera.CameraMode != CameraMode.Follow)
            {
                if (InputHandler.KeyReleased(Keys.C))
                    camera.LockToSprite(sprite);
            }

        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            sprite.Draw(gameTime, spriteBatch, camera);
        }
        #endregion
    }
}
