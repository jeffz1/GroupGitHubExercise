using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGitHubExercise
{
    public class Card
    {
        public readonly static string[] Faces = { "Ace", "Two", "Three", "Four", "Five", "Six",
                               "Seven", "Eight", "Nine", "Ten",
                               "Jack", "Queen", "King"};
        public readonly static string[] Suits = { "Donkeys", "Camels", "Horses", "Snakes" };

        private int face;
        public int Face
        {
            get { return face; }
            private set
            {
                if (value < 0 || value > Faces.Length)
                    throw new Exception("Invalid value for Face");
                face = value;
            }
        }

        private int suit;
        public int Suit
        {
            get { return suit; }
            private set
            {
                if (value < 0 || value > Suits.Length)
                    throw new Exception("Invalid value for Suit");
                suit = value;
            }
        }

        public Card(int face, int suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString() => $"{Faces[face]} of {Suits[suit]}";
    }
}
