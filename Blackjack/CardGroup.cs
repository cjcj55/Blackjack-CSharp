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

        public int GetHandValue()
        {
            int handValue = 0;
            for (int i = 0; i < NumCards; i++)
            {
                handValue += cards[i].GetValue();
            }
            return handValue;
        }

        public Card GetCard(int index)
        {
            if (index < 0 || index >= cards.Length)
            {
                return null;
            }
            return cards[index - 1];
        }

        public void SetCard(int index, Card card)
        {
            cards[index - 1] = card;
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
                foreach (char suit in new char[] { 'S', 'H', 'C', 'D' })
                {
                    foreach (char face in new char[] {'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K'})
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

            Card topCard = this.cards[0];
            this.NumCards--;

            // Shift all cards to the left
            for (int i = 0; i < NumCards; i++)
            {
                this.cards[i] = this.cards[i + 1];
            }

            // Set last card to null (it is removed)
            this.cards[NumCards] = null;

            return topCard;
        }

        public Card[] GetCards()
        {
            return this.cards;
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
