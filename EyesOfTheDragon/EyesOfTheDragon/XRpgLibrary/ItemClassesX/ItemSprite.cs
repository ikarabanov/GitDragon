using EyesOfTheDragon.XRpgLibrary.ItemClasses;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClassesX
{
    public class ItemSprite
    {
        #region Field Region
        BaseSprite sprite;
        BaseItem item;
        #endregion

        #region Property Region
        public BaseSprite Sprite
        {
            get { return sprite; }
        }
        public BaseItem Item
        {
            get { return item; }
        }
        #endregion

        #region Constructors Region
        public ItemSprite(BaseItem item, BaseSprite sprite)
        {
            this.item = item;
            this.sprite = sprite;
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        public virtual void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }
        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            sprite.Draw(gameTime, spriteBatch);
        }
        #endregion
    }
}
