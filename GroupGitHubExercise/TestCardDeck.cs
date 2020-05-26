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
            DisplayDeck();
        }

        private void DisplayDeck()
        {
            var card = deck.Deal();
            while (card != null)
            {
                Console.WriteLine(card);
                card = deck.Deal();
            }
        }
    }
}
