using GameEngine;
using SFML.System;
using System.Diagnostics.Metrics;

namespace MyGame
{
    public class GameScene : Scene
    {
        public GameScene()
        {
            Player player = new Player();
            AddGameObject(player);
            Fruit fruit = new Fruit(new Vector2f(0, 0));
            AddGameObject(fruit);
        }
    }
}