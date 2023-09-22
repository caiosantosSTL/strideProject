using Stride.Engine;

namespace MyGameInit
{
    class MyGameInitApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
