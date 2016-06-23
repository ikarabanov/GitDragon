using EyesOfTheDragon.XRpgLibrary.TileEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.WorldClasses
{
    public class Level
    {
        #region Field Region
        readonly TileMap map;
        #endregion

        #region Property Region
        public TileMap Map
        {
            get { return map; }
        }
        #endregion

        #region Constructor Region
        public Level(TileMap tileMap)
        {
            map = tileMap;
        }
        #endregion

        #region Method Region
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            map.Draw(spriteBatch, camera);
        }
        #endregion
    }
}
