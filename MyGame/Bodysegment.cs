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
    class Bodysegment :GameObject
    {
        private readonly Sprite _sprite = new Sprite();
        public Bodysegment(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/meteor.png");
            _sprite.Position = pos;
            AssignTag("bodysegment");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            Vector2f pos = _sprite.Position;
            
        }
    }
}
