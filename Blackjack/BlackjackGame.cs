using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    internal class BlackjackGame
    {
        public CardGroup deck;
        public CardGroup playerCards;
        public CardGroup dealerCards;
        public Score score;

        public BlackjackGame()
        {
            deck = new CardGroup();
            deck.MakeWholeDeck();
            deck.Shuffle();
            playerCards = new CardGroup();
            dealerCards = new CardGroup();
            score = new Score();
        }

        public bool DealCards()
        {
            if (deck != null && playerCards != null && dealerCards != null && deck.NumCards >= 4)
            {
                playerCards.AddToDeck(deck.DealTopCard());
                dealerCards.AddToDeck(deck.DealTopCard());
                playerCards.AddToDeck(deck.DealTopCard());
                dealerCards.AddToDeck(deck.DealTopCard());
                return true;
            }
            return false;
        }

        /**
         * If the dealer's face-up card is an Ace, offer the player insurance before revealing their hole card.
         * The player can then take insurance or decline it.
         */
        public bool OfferPlayerInsurance()
        {
            if (dealerCards != null && dealerCards.NumCards == 2)
            {
                if (dealerCards.GetCard(0).GetValue() == 'A')
                {
                    return true;
                }
            }
            return false;
        }

        /** 
         * Dealer checks hole card to see if they have blackjack.
         * If they have blackjack, the hand ends immediately and the player also loses unless they have blackjack (hand is a tie).
         */
        public bool CheckDealerCardsForBlackjack()
        {
            if (dealerCards != null && dealerCards.NumCards == 2 && dealerCards.GetHandValue() == 21)
            {
                return true;
            }
            return false;
        }


        public void PlayerHit()
        {
            if (playerCards.NumCards <= 52)
            {
                playerCards.AddToDeck(deck.DealTopCard());
            }
        }

        /**
         * Check if the player busted or not
         */
        public bool PlayerBust()
        {
            if (playerCards.GetHandValue() > 21)
            {
                return true;
            }
            return false;
        }

        /**
         * Ends player's turn when they choose to stand
         */
        public void PlayerChoosesToStand()
        {
            // Player has finished their turn, now it's the dealer's turn
            while (dealerCards.GetHandValue() < 17)
            {
                // Dealer must hit until their hand value is at least 17
                dealerCards.AddToDeck(deck.DealTopCard());
            }
        }

        public int CalculateWinner()
        {
            int playerHandValue = playerCards.GetHandValue();
            int dealerHandValue = dealerCards.GetHandValue();

            // Check if the player busted
            if (PlayerBust())
            {
                return -1;
            }

            // Check if the dealer busted
            if (dealerHandValue > 21)
            {
                return 1;
            }

            // Check for a tie
            if (playerHandValue == dealerHandValue)
            {
                return 0;
            }

            // Check for a natural blackjack
            if (playerHandValue == 21 && playerCards.NumCards == 2 && dealerHandValue != 21)
            {
                return 1;
            }
            else if (dealerHandValue == 21 && dealerCards.NumCards == 2 && playerHandValue != 21)
            {
                return -1;
            }

            // Check for the highest hand value without busting
            if (playerHandValue > dealerHandValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /**
         * Keeps track of the player's and dealer's wins
         */
        public void ModifyScore()
        {
            int winner = CalculateWinner();
            if (winner == 1)
            {
                score.IncrementPlayerWins();
            } else if (winner == -1)
            {
                score.IncrementDealerWins();
            }
        }

        /**
         * TODO for later
         */
        public bool CanSplit()
        {
            if (playerCards.NumCards == 2 && playerCards.GetCard(0).Face == playerCards.GetCard(1).Face)
            {
                // The player can split if they have two cards of the same rank
                return true;
            }
            return false;
        }
    }
}
