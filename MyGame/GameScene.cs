using GameEngine;

namespace MyGame
{
    public class GameScene : Scene
    {
        public GameScene()
        {
            Player player = new Player();
            AddGameObject(player);
        }
    }
}