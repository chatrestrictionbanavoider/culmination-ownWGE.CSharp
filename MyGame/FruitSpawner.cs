using GameEngine;
using SFML.Graphics;
using SFML.System;
using System.Diagnostics.Metrics;

namespace MyGame
{
    class FruitSpawner : GameObject
    {
        // The number of milliseconds between fruit spawns.
        private const int SpawnDelay = 1000;
        private int _timer;
        public override void Update(Time elapsed)
        {
            // Determine how much time has passed and adjust our timer
            int msElapsed = elapsed.AsMilliseconds();
            _timer -= msElapsed;

            //If our timer has elapsed, reset it and spawn a fruit
            if (_timer <= 0)
            {
                _timer = SpawnDelay;
                Vector2u size = Game.RenderWindow.Size;

                
                // Spawn the fruit somewhere at the top
                float fruitX = Game.Random.Next() % size.Y;

                float fruitY = 0;
                // Create a fruit and add it 
                Fruit fruit = new Fruit(new Vector2f(fruitX, fruitY));
                Game.CurrentScene.AddGameObject(fruit);
            }
        }
    }
}
