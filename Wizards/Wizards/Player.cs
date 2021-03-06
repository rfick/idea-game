﻿using System;
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
            nextPos += mSpeed * (float)theGameTime.ElapsedGameTime.TotalSeconds;
            if (nextPos.X < 0)
            {
                nextPos.X = 0;
                mSpeed.X = 0;
            }
            if (nextPos.Y < 0)
            {
                nextPos.Y = 0;
                mSpeed.Y = 0;
            }
            if ((nextPos.X + Size.Width) > graphics.GraphicsDevice.Viewport.Width)
            {
                nextPos.X = graphics.GraphicsDevice.Viewport.Width - Size.Width;
                mSpeed.X = 0;
            }
            if ((nextPos.Y + Size.Height) > graphics.GraphicsDevice.Viewport.Height)
            {
                nextPos.Y = graphics.GraphicsDevice.Viewport.Height - Size.Height;
                mSpeed.Y = 0;
            }
            Position = nextPos;
        }

        private void UpdateMovement(KeyboardState aCurrentKeyboardState)
        {
            if (mCurrentState == State.Walking)
            {
                if (aCurrentKeyboardState.IsKeyDown(Keys.A) == true)
                {
                    if (Math.Abs(mSpeed.X) < WIZARD_SPEED)
                    {
                        mSpeed.X -= 0.01f * WIZARD_SPEED;
                    }
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.D) == true)
                {
                    if (Math.Abs(mSpeed.X) < WIZARD_SPEED)
                    {
                        mSpeed.X += 0.01f * WIZARD_SPEED;
                    }
                }
                if (aCurrentKeyboardState.IsKeyDown(Keys.W) == true)
                {
                    if (Math.Abs(mSpeed.Y) < WIZARD_SPEED)
                    {
                        mSpeed.Y -= 0.01f * WIZARD_SPEED;
                    }
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.S) == true)
                {
                    if (Math.Abs(mSpeed.Y) < WIZARD_SPEED)
                    {
                        mSpeed.Y += 0.01f * WIZARD_SPEED;
                    }
                }
            }
        }

    }
}
