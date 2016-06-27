using EyesOfTheDragon.XRpgLibrary.CharacterClasses;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.CharacterClassesX
{
    public class Character
    {
        #region Field Region
        protected Entity entity;
        protected AnimatedSprite sprite;
        #endregion

        #region Property Region
        public Entity Entity
        {
            get { return entity; }
        }
        public AnimatedSprite Sprite
        {
            get { return sprite; }
        }
        #endregion

        #region Constructors Region
        public Character(Entity entity, AnimatedSprite sprite)
        {
            this.entity = entity;
            this.sprite = sprite;
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        public virtual void Update(GameTime gameTime)
        {
            entity.Update(gameTime.ElapsedGameTime);
            sprite.Update(gameTime);
        }
        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            sprite.Draw(gameTime, spriteBatch);
        }
        #endregion
    }
}
