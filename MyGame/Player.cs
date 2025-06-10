using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace MyGame
{
    public class Player : GameObject
    {
        private const float Speed = .3f;
        private readonly Sprite _sprite = new Sprite();
        int length = 2;
        Keyboard.Key direction = Keyboard.Key.Down;
        public Player()
        {
            _sprite.Texture = Game.GetTexture("Resources/snakehead.png");
            _sprite.Position = new Vector2f(100, 100);
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            Vector2f pos = _sprite.Position;
            float x = pos.X;
            float y = pos.Y;
            int msElapsed = elapsed.AsMilliseconds();
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { direction = Keyboard.Key.Up; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { direction = Keyboard.Key.Down; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { direction = Keyboard.Key.Left; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { direction = Keyboard.Key.Right; }

            _sprite.Position = new Vector2f(x, y);

        }
    }
}
