using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace EyesOfTheDragon.XRpgLibrary
{
    public class InputHandler : GameComponent
    {
        #region Keyboard Field Region
        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;
        #endregion

        #region Game Pad Field Region
        static GamePadState[] gamePadStates;
        static GamePadState[] lastGamePadStates;
        #endregion

        #region Keyboard Property Region
        public static KeyboardState KeyboardState
        {
            get { return keyboardState; }
        }
        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }
        #endregion

        #region Game Pad Property Region
        public static GamePadState[] GamePadStates
        {
            get { return gamePadStates; }
        }
        public static GamePadState[] LastGamePadStates
        {
            get { return LastGamePadStates; }
        }
        #endregion

        #region Constructor Region
        public InputHandler(Game game) : base(game)
        {
            keyboardState = Keyboard.GetState();

            gamePadStates = new GamePadState[Enum.GetValues(typeof(PlayerIndex)).Length];

            foreach (PlayerIndex index in Enum.GetValues(typeof(PlayerIndex)))
                gamePadStates[(int)index] = GamePad.GetState(index);
        }
        #endregion

        #region XNA Methods
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            lastGamePadStates = (GamePadState[])gamePadStates.Clone();
            foreach (PlayerIndex index in Enum.GetValues(typeof(PlayerIndex)))
                gamePadStates[(int)index] = GamePad.GetState(index);

            base.Update(gameTime);
        }
        #endregion

        #region General Method Region
        public static void Flush()
        {
            lastKeyboardState = keyboardState;
        }
        #endregion

        #region Keyboard Region
        public static bool KeyReleased(Keys key) //Use for menu to trigger on release instead of on press and skip through all menues
        {
            return keyboardState.IsKeyUp(key) && lastKeyboardState.IsKeyDown(key);
        }
        public static bool KeyPressed(Keys key)
        {
            return keyboardState.IsKeyDown(key) && lastKeyboardState.IsKeyUp(key);
        }
        public static bool KeyDown(Keys key)
        {
            return keyboardState.IsKeyDown(key);
        }
        #endregion

        #region Game Pad Region
        public static bool ButtonReleased(Buttons button, PlayerIndex index)
        {
            return gamePadStates[(int)index].IsButtonUp(button) && lastGamePadStates[(int)index].IsButtonDown(button);
        }
        public static bool ButtonPressed(Buttons button, PlayerIndex index)
        {
            return gamePadStates[(int)index].IsButtonDown(button) && lastGamePadStates[(int)index].IsButtonUp(button);
        }
        public static bool ButtonDown(Buttons button, PlayerIndex index)
        {
            return gamePadStates[(int)index].IsButtonDown(button);
        }
        #endregion

    }
}
