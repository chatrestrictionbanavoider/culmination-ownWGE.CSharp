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
    internal class Apple : GameObject
    {
        private readonly Sprite _sprite = new Sprite();
        public Apple(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/apple.png");
            _sprite.Position = pos;
            AssignTag("apple");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            //MakeDead();
        }
    }
}
