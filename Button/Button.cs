using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Button
{
    public class Button
    {
        private readonly Texture2D _texture;
        private Vector2 _position;
        private readonly Rectangle _rect;
        private Color _shade = Color.White;

        public Button(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            _position = position;
            _rect = new((int)position.X, (int)position.Y, texture.Width, texture.Height);          
        }

        public void Update()
        {
            if (Globals.MouseCursor.Intersects(_rect))
            {
                _shade = Color.DarkGray;
                if (Globals.Clicked) 
                {
                    Click();
                }
            }
            else
            {
                _shade = Color.White;
            }
        }

        public event EventHandler OnClick;
        private void Click()
        {
            OnClick?.Invoke(this, EventArgs.Empty);
        }

        public void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, _position, _shade);
        }
    }
}
