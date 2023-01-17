using GameEngine;
using SFML.System;

namespace MyGame
{
    class GameScene : Scene
    {
        private int _score;
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);
            // a couple lines to test the meteor
            //Meteor meteor = new Meteor(new Vector2f(650,250));
            //AddGameObject(meteor);

            MeteorSpawner meteorSpawner = new MeteorSpawner();
            AddGameObject(meteorSpawner);

            Score score = new Score(new Vector2f(10.0f, 10.0f));
            AddGameObject(score);
        }

        // Get the current score
        public int GetScore()
        {
            return _score;
        }

        // Increase the score
        public void IncreaseScore()
        {
            ++_score;
        }
    }
}