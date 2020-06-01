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
            //Fix #5 allow shuffle without endless loop, show 54 cards to prove shuffle worked 
            //while (card != null)
            for (int i = 0; i < CardDeck.NUMBER_OF_FACES * CardDeck.NUMBER_OF_SUITS + 2; i++)
            {
                Console.WriteLine($"{ card} card no: { (i+1).ToString()}");
                card = deck.Deal();
            }
        }
    }
}
