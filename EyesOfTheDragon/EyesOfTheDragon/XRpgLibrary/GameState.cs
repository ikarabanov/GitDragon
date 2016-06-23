using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace EyesOfTheDragon.XRpgLibrary
{
    public abstract partial class GameState : DrawableGameComponent
    {
        #region Fields and Properties
        List<GameComponent> childComponent;
        public List<GameComponent> Components
        {
            get { return childComponent; }
        }

        GameState tag;
        public GameState Tag
        {
            get { return tag; }
        }

        protected GameStateManager StateManager;
        #endregion

        #region Constructor Region
        public GameState(Game game, GameStateManager manager) : base(game)
        {
            StateManager = manager;
            childComponent = new List<GameComponent>();
            tag = this;
        }
        #endregion

        #region XNA Drawable Game Component Methods
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            foreach(GameComponent component in childComponent)
            {
                if (component.Enabled)
                    component.Update(gameTime);
            }
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            DrawableGameComponent drawComponent;
            foreach(GameComponent component in childComponent)
            {
                if (component is DrawableGameComponent)
                {
                    drawComponent = component as DrawableGameComponent;
                    if (drawComponent.Visible)
                        drawComponent.Draw(gameTime);
                }
            }
            base.Draw(gameTime);
        }
        #endregion

        #region GameState Method Region
        internal protected virtual void StateChange(object sender, EventArgs e)
        {
            if (StateManager.CurrentState == Tag)
                Show();
            else
                Hide();
        }
        protected virtual void Show()
        {
            Visible = true;
            Enabled = true;
            foreach(GameComponent component in childComponent)
            {
                component.Enabled = true;
                if (component is DrawableGameComponent)
                    ((DrawableGameComponent)component).Visible = true;
            }
        }
        protected virtual void Hide()
        {
            Visible = false;
            Enabled = false;
            foreach (GameComponent component in childComponent)
            {
                component.Enabled = false;
                if (component is DrawableGameComponent)
                    ((DrawableGameComponent)component).Visible = false;
            }
        }
        #endregion


    }
}
