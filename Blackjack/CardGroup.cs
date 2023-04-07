using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class CardGroup
    {
        private Card[] cards;
        private int numCards;

        public CardGroup()
        {
            cards = new Card[52];
            numCards = 0;
        }


        public int NumCards
        {
            get { return numCards; }
            set { numCards = value; }
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public void SetCard(int index, Card card)
        {
            cards[index] = card;
        }

        public void AddToDeck(Card card)
        {
            cards[this.NumCards] = card;
            NumCards++;
        }

        public void MakeWholeDeck()
        {
            if (numCards == 0)
            {
                foreach (char suit in new char[] { 'A', 'H', 'C', 'D' })
                {
                    foreach (char face in new char[] {'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T'})
                    {
                        this.cards[NumCards++] = new Card(face, suit);
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = NumCards - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = this.cards[i];
                this.cards[i] = this.cards[j];
                this.cards[j] = temp;
            }
        }

        public Card DealTopCard()
        {
            if (this.NumCards == 0)
            {
                throw new InvalidOperationException("Cannot remove a card from an empty deck");
            }

            Card topCard = this.cards[this.NumCards--];
            this.cards[NumCards] = null;
            return topCard;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Deck contains:\n");

            for (int i = 0; i < NumCards; i++)
            {
                sb.Append(this.cards[i].ToString() + " ");
            }

            return sb.ToString();
        }
    }
}
