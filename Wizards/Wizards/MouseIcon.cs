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
    class MouseIcon : Sprite
    {
        const string WIZARD_ASSETNAME = "Fireball";
        const int START_POSITION_X = 0;
        const int START_POSITION_Y = 0;

        enum State
        {
            Walking
        }
        State mCurrentState = State.Walking;
        Vector2 mDirection = Vector2.Zero;
        Vector2 mSpeed = Vector2.Zero;
        MouseState currMouse;

        public void LoadContent(ContentManager theContentManager)
        {
            Position = new Vector2(START_POSITION_X, START_POSITION_Y);
            base.LoadContent(theContentManager, WIZARD_ASSETNAME);
            Scale = 0.1f;
        }

        // Figure out where the mouse is at all times.
        // Note: only works for windows right now(ie. not phones, xbox, etc)
        public void Update()
        {
            MouseState ms = Mouse.GetState();
            currMouse = ms;
            #if WINDOWS
                Position.X = ms.X;
                Position.Y = ms.Y;
            #endif
        }

    }
}