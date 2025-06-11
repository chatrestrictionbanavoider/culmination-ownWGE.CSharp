using GameEngine;
using SFML.System;
using System.Diagnostics.Metrics;
using static System.Formats.Asn1.AsnWriter;

namespace MyGame
{
    public class GameScene : Scene
    {
        private int score = 0;
        private int lives = 5;
        public GameScene()
        {
            Player player = new Player();
            AddGameObject(player);
            FruitSpawner fruitspawner= new FruitSpawner();
            AddGameObject(fruitspawner);
            Score score = new Score(new Vector2f(0f,0f));
            AddGameObject(score);
            Lives lives = new Lives(new Vector2f(0f, 24f));
            AddGameObject(lives);
        }
        public int GetScore()
        {
            return score;
        }
        public void IncreaseScore()
        {
            ++score;
        }
        public int GetLives()
        {
            return lives;
        }
        public void DecreaseLives()
        {
            --lives;
            if (lives == 0)
            {
                DeathScreen deathscreen = new DeathScreen(score);
                Game.SetScene(deathscreen);
            }
        }

    }
}