using EyesOfTheDragon.XRpgLibrary;
using EyesOfTheDragon.XRpgLibrary.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace EyesOfTheDragon.GameScreens
{
    public abstract partial class BaseGameState : GameState
    {
        #region Fields Region
        protected EyesOfTheDragon GameRef;
        protected ControlManager ControlManager;
        protected PlayerIndex playerIndexInControl;
        #endregion

        #region Properties Region
        #endregion

        #region Constructor Region
        public BaseGameState(Game game, GameStateManager manager) : base(game, manager)
        {
            GameRef = (EyesOfTheDragon)game;

            playerIndexInControl = PlayerIndex.One;
        }
        #endregion

        #region XNA Method region
        protected override void LoadContent()
        {
            ContentManager Content = Game.Content;

            SpriteFont menuFont = Content.Load<SpriteFont>("Fonts\\ControlFont");
            ControlManager = new ControlManager(menuFont);

            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
        #endregion
    }
}
