using EyesOfTheDragon.XRpgLibrary.CharacterClasses;
using EyesOfTheDragon.XRpgLibrary.ItemClassesX;
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

        //Armor fields
        protected GameItem head;
        protected GameItem body;
        protected GameItem hands;
        protected GameItem feet;

        //Weapons/Shield fields
        protected GameItem mainHand;
        protected GameItem offHand;

        protected int handsFree;
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
        public GameItem Head
        {
            get{ return head; }
        }
        public GameItem Body
        {
            get{ return body; }
        }
        public GameItem Hands
        {
            get{ return hands; }
        }
        public GameItem Feet
        {
            get{ return feet; }
        }
        public GameItem MainHand
        {
            get{ return mainHand; }
        }
        public GameItem OffHand
        {
            get{ return OffHand; }
        }
        public int HandsFree
        {
            get { return handsFree; }
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
        public virtual bool Equip(GameItem gameItem)
        {
            bool success = false;

            return success;
        }
        public virtual bool Unequip(GameItem gameItem)
        {
            bool success = false;

            return success;
        }
        #endregion
    }
}
