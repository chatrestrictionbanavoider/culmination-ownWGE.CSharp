using GameEngine;

namespace MyGame
{
    class DeathScreen : Scene
    {
        public DeathScreen(int score)
        {
            GameOverMessage gameOverMessage = new GameOverMessage(score);
            AddGameObject(gameOverMessage);
        }
    }
}
