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
        Keyboard.Key direction = Keyboard.Key.Down;
        public Player()
        {
            _sprite.Texture = Game.GetTexture("Resources/bucket.png");
            _sprite.Position = new Vector2f(193, 370);
            AssignTag("player");
        }
        public override FloatRect GetCollisionRect()
        {
            return _sprite.GetGlobalBounds();
        }

        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            Vector2f prevpos = _sprite.Position;
            Vector2f pos = _sprite.Position;
            float x = pos.X;
            float y = pos.Y;
            int msElapsed = elapsed.AsMilliseconds();
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
            _sprite.Position = new Vector2f(x, y);
        }
    }
}
