using GameEngine;
using SFML.Graphics;
using SFML.System;
using System;


namespace MyGame
{
    class Fruit : GameObject
    {
        private const float Speed = 0.1f;
        private readonly Sprite _sprite = new Sprite();
        public Fruit(Vector2f pos)
        {
            Random rng = new Random();
            int rn = rng.Next(1, 7); //we will use this random stuff to determine what fruit it spawns
            string texturepath = "Resources/apple.png";
            if (rn == 1)
            {
                texturepath = "Resources/banana.png";
            }
            if (rn == 2)
            {
                texturepath = "Resources/orange.png";
            }
            if (rn == 3)
            {
                texturepath = "Resources/strawberry.png";
            }
            if (rn == 4)
            {
                texturepath = "Resources/eggplant.png";
            }
            if (rn == 5)
            {
                texturepath = "Resources/pickle.png";
            }
            if (rn == 6)
            {
                texturepath = "Resources/apple.png";
            }
            _sprite.Texture = Game.GetTexture(texturepath);
            _sprite.Position = pos;
            AssignTag("fruit");
        }
        public override FloatRect GetCollisionRect()
        {
            return _sprite.GetGlobalBounds();
        }
        public override void HandleCollision(GameObject otherGameObject)
        {
            if (otherGameObject.HasTag("player"))
            {
                GameScene scene = (GameScene)Game.CurrentScene;
                scene.IncreaseScore();
                MakeDead();
            }
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }

        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            if (pos.Y > Game.RenderWindow.Size.Y)
            {
                MakeDead(); //kill our guy if hes out of bounds
                GameScene scene = (GameScene)Game.CurrentScene;
                scene.DecreaseLives(); //removes our lives
            }
            else
            {
                  _sprite.Position = new Vector2f(pos.X, pos.Y + Speed * msElapsed); //sets position to move downward (add to y which moves down) * time, keeps X the same.
            }
        }
    }
}
