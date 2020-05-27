using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitHubExercise
{
    public class HiLoGame
    {
        public Card[] Cards;
        private bool AceHigh { get; set; } = false;

        public string PlayAHand()
        {
            string winner = "Nobody yet";

            // Start out with a initialed and shuffled deck
            CardDeck deck = new CardDeck();
            deck.Shuffle();
            // Deal two cards
            Card card1 = deck.Deal();
            Card card2 = deck.Deal();

            //Added to show cards
            Cards = new Card[2];
            Cards[0] = card1;
            Cards[1] = card2;

            // Compare the cards
            //Suit doesn't matter
            if (card1.Face == card2.Face)
                winner = "Tie";
            else if (card1.Face > card2.Face || card1.Face == 0)
                winner = "Player 1 wins";
            else if (card1.Face > card2.Face || card2.Face == 0)
                winner = "Player 2 wins";

            // Whoever has the higher card wins
            return winner;
        }

        public void PlayGame()
        {
            // PlayAHand until the cows come home (or someone quits)
            // Figure out how to reshuffle
            //    How to end the program
            //    How to reward the player (Good Job! You've won 17 out 21 times)
            Console.Write("Do you want to count an Ace as High or Low (h/l)? :");
            if (Console.ReadLine().ToLower() == "h")
                AceHigh = true;

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine(PlayAHand());
                Console.WriteLine($"Player 1: {Cards[0]}");
                Console.WriteLine($"Player 2: {Cards[1]}");
                Console.Write("Play again? (y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                    playAgain = false;
                Console.WriteLine();
            }
        }
    }
}
