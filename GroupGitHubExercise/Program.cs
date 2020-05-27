using System;

namespace GroupGitHubExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestCardDeck();
            test.Run();

            var game = new HiLoGame();
            game.PlayGame();
        }
    }
}
