using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClassesX
{
    public class GameItemManager
    {
        #region Field Region
        readonly Dictionary<string, GameItem> gameItems = new Dictionary<string, GameItem>();
        static SpriteFont spriteFont;
        #endregion

        #region Property Region
        public Dictionary<string, GameItem> GameItems
        {
            get { return gameItems; }
        }
        public static SpriteFont SpriteFont
        {
            get { return spriteFont; }
            private set { spriteFont = value; }
        }
        #endregion

        #region Cosntructor Region
        public GameItemManager(SpriteFont spriteFont)
        {
            SpriteFont = spriteFont;
        }
        #endregion

        #region Method Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
