using System;
using System.Collections.Generic;
using System.Text;

namespace GroupGitHubExercise
{
    class CardDeck
    {
        private Card[] Deck { get; set; }
        private int currentCard;
        private Random _rnd = new Random();

        public CardDeck()
        {
            Deck = new Card[Card.Faces.Length * Card.Suits.Length];
            currentCard = 0;


            int cardIndex = 0;
            for (int suit = 0; suit < 3; suit++)
            {
                for (int face = 0; face < 11; face++)
                {
                    Deck[cardIndex++] = new Card(face, suit);
                }
            }
        }

        public Card Deal()
        {
            if (currentCard >= Deck.Length)
                throw new ApplicationException("Ran out of cards");
            else
                return Deck[currentCard++];
        }
    }
}
