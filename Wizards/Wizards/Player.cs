using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Wizards
{
    class Player : Sprite
    {
        const string WIZARD_ASSETNAME = "Knight";
        const int START_POSITION_X = 0;
        const int START_POSITION_Y = 0;
        const int WIZARD_SPEED = 700;
        const int MOVE_UP = -1;
        const int MOVE_DOWN = 1;
        const int MOVE_LEFT = -1;
        const int MOVE_RIGHT = 1;

        enum State
        {
            Walking
        }
        State mCurrentState = State.Walking;
        Vector2 mDirection = Vector2.Zero;
        Vector2 mSpeed = Vector2.Zero;
        KeyboardState mPreviousKeyboardState;

        public void LoadContent(ContentManager theContentManager)
        {
            Position = new Vector2(START_POSITION_X, START_POSITION_Y);
            base.LoadContent(theContentManager, WIZARD_ASSETNAME);
        }

        public void Update(GameTime theGameTime, GraphicsDeviceManager graphics)
        {
            KeyboardState aCurrentKeyboardState = Keyboard.GetState();
            UpdateMovement(aCurrentKeyboardState);
            mPreviousKeyboardState = aCurrentKeyboardState;

            // Do the position calculation and bound the player on the screen:
            Vector2 nextPos = Position;
            nextPos += mDirection * mSpeed * (float)theGameTime.ElapsedGameTime.TotalSeconds;
            if (nextPos.X < 0)
            {
                nextPos.X = 0;
            }
            if (nextPos.Y < 0)
            {
                nextPos.Y = 0;
            }
            if ((nextPos.X + Size.Width) > graphics.GraphicsDevice.Viewport.Width)
            {
                nextPos.X = graphics.GraphicsDevice.Viewport.Width - Size.Width;
            }
            if ((nextPos.Y + Size.Height) > graphics.GraphicsDevice.Viewport.Height)
            {
                nextPos.Y = graphics.GraphicsDevice.Viewport.Height - Size.Height;
            }
            Position = nextPos;
        }

        private void UpdateMovement(KeyboardState aCurrentKeyboardState)
        {
            if (mCurrentState == State.Walking)
            {
                mSpeed = Vector2.Zero;
                mDirection = Vector2.Zero;
                if (aCurrentKeyboardState.IsKeyDown(Keys.A) == true)
                {
                    mSpeed.X = WIZARD_SPEED;
                    mDirection.X = MOVE_LEFT;
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.D) == true)
                {
                    mSpeed.X = WIZARD_SPEED;
                    mDirection.X = MOVE_RIGHT;
                }
                if (aCurrentKeyboardState.IsKeyDown(Keys.W) == true)
                {
                    mSpeed.Y = WIZARD_SPEED;
                    mDirection.Y = MOVE_UP;
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.S) == true)
                {
                    mSpeed.Y = WIZARD_SPEED;
                    mDirection.Y = MOVE_DOWN;
                }
            }
        }

    }
}
