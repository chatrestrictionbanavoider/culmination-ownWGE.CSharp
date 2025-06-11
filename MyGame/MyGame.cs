using GameEngine;
namespace MyGame
{
    public static class MyGame
    {
        private const int WindowWidth = 400;
        private const int WindowHeight = 400;

        private const string WindowTitle = "they called him bucket boy";

        public static void Main(string[] args)
        {
            // Initialize the game.
            Game.Initialize(WindowWidth, WindowHeight, WindowTitle);

            // Create our scene.
            GameScene scene = new GameScene();
            Game.SetScene(scene);

            // Run the game loop.
            Game.Run();
        }
    }
}