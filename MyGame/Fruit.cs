using GameEngine;
using SFML.Graphics;
using SFML.System;

namespace MyGame
{
    class Fruit : GameObject
    {
        private const float Speed = 0.5f;

        private readonly Sprite _sprite = new Sprite();

        public Fruit(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/apple.png");
            _sprite.Position = pos;
            AssignTag("fruit");
        }

        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }

        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            if (pos.Y < _sprite.GetGlobalBounds().Width * -1)
            {
                MakeDead();
            }
            else
            {
                _sprite.Position = new Vector2f(pos.Y + Speed * msElapsed, pos.X);
            }
        }
    }
}
