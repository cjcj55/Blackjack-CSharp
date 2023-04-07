using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Card
    {
        private char face;
        private char suit;

        public Card()
        {
            face = 'N';
            suit = 'N';
        }

        public Card(char face, char suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public char Face
        {
            get { return face; }
            set { face = value; }
        }

        public char Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public override string ToString()
        {
            return Face.ToString() + Suit;
        }

        public int GetValue()
        {
            if (Face == 'A')
            {
                return 11;
            } 
            else if (face == 'K' || face == 'Q' || face == 'J' || face == 'T')
            {
                return 10;
            }
            else
            {
                return face;
            }
        }

        public string FileName()
        {
            return "Resources/" + Face + Suit + ".png";
        }
    }
}
