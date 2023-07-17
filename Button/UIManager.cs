using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Button
{
    public class UIManager
    {
        private Texture2D ButtonTexture { get; }
        private SpriteFont Font { get; }
        private readonly List<Button> Buttons = new();
        public int Counter { get; set; }

        public UIManager()
        {
            ButtonTexture = Globals.Content.Load<Texture2D>("ButtonTexture");
            Font = Globals.Content.Load<SpriteFont>("ButtonFont");
        }

        public Button AddButton(Vector2 position)
        {
            Button button = new(ButtonTexture, position);
            Buttons.Add(button);
            return button;
        }

        public void Update()
        {
            foreach (var button in Buttons)
            {
                button.Update();
            }
        }

        public void Draw()
        {
            foreach (var button in Buttons)
            {
                button.Draw();
            }

            Globals.SpriteBatch.DrawString(Font, Counter.ToString(), new(10, 10), Color.Black);
        }
    }
}
