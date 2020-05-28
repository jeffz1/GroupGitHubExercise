using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitHubExercise
{
    public class TestCardDeck
    {
        private CardDeck deck;

        public void Run()
        {
            deck = new CardDeck();
            deck.Shuffle();
            DisplayDeck();
        }

        private void DisplayDeck()
        {
            var card = deck.Deal();
            int count = 0;
            while (card != null)
            {
                if (count++ > 100)
                {
                    Console.WriteLine("The deck appears to be endless - it must be automatically reshuffling!");
                    break;
                }
                Console.WriteLine(card);
                card = deck.Deal();
            }
        }
    }
}
