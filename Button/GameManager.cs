using System;

namespace Button
{
    public class GameManager
    {
        private readonly UIManager _manager = new();

        public GameManager()
        {
            _manager.AddButton(new(100, 100)).OnClick += Action;
            _manager.AddButton(new(500, 100)).OnClick += ActionM1;
            _manager.AddButton(new(100, 500)).OnClick += Action10;
            _manager.AddButton(new(500, 500)).OnClick += ActionM10;
        }

        public void Action(object sender, EventArgs e)
        {
            _manager.Counter++;
        }

        public void Action10(object sender, EventArgs e)
        {
            _manager.Counter += 10;
        }

        public void ActionM1(object sender, EventArgs e)
        {
            _manager.Counter--;
        }

        public void ActionM10(object sender, EventArgs e)
        {
            _manager.Counter -= 10;
        }

        public void Update()
        {
            _manager.Update();
        }

        public void Draw()
        {
            _manager.Draw();
        }
    }
}
