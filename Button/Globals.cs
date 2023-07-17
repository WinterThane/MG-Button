﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Button
{
    public static class Globals
    {
        public static ContentManager Content { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static MouseState MouseState { get; set; }
        public static MouseState LastMouseState { get; set; }
        public static bool Clicked { get; set; }
        public static Rectangle MouseCursor { get; set; }

        public static void Update()
        {
            LastMouseState = MouseState;
            MouseState = Mouse.GetState();  

            Clicked = MouseState.LeftButton == ButtonState.Pressed && LastMouseState.LeftButton == ButtonState.Released;
            MouseCursor = new(MouseState.Position, new(1, 1));
        }
    }
}
