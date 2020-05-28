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
           for (int i = 0; i < CardDeck.NUMBER_OF_FACES * CardDeck.NUMBER_OF_SUITS + 2; i++)
            //while (card != null)
           {
                Console.WriteLine($"{ card} { i.ToString()}");
                card = deck.Deal();
            }
        }
    }
}
