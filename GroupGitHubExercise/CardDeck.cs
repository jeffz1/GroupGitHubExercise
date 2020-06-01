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

        private readonly int NUMBER_OF_FACES = 11;
        private readonly int NUMBER_OF_SUITS = 0;

        public CardDeck()
        {
            NUMBER_OF_SUITS = Card.Suits.Length;

            Deck = new Card[NUMBER_OF_FACES * NUMBER_OF_SUITS];
            currentCard = 0;


            int cardIndex = 0;
            for (int suit = 0; suit < NUMBER_OF_SUITS; suit++)
            {
                for (int face = 0; face < NUMBER_OF_FACES; face++)
                {
                    Deck[cardIndex++] = new Card(face, suit);
                }
            }
        }

        public Card Deal()
        {
            if (currentCard >= Deck.Length)
                return null;
            else
                return Deck[currentCard++];
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int card = 0; card < Deck.Length; card++)
            {
                int randomIndex = _rnd.Next(0, Deck.Length);
                Card temp = Deck[card];
                //Deck[card] = temp;    // Will put a card in two places
                Deck[card] = Deck[randomIndex];
                Deck[randomIndex] = temp;
            }
        }
    }
}
