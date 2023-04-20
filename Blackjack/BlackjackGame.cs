using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    internal class BlackjackGame
    {
        public CardGroup deck;
        public CardGroup playerCards;
        public CardGroup dealerCards;
        public bool IsRunning { get; set; }

        /// <summary>
        ///     Creates a new Blackjack game, creating a new deck of cards and shuffling the deck, initializing an empty hand for the player and an empty hand for the dealer.
        /// </summary>
        public BlackjackGame()
        {
            deck = new CardGroup();
            deck.MakeWholeDeck();
            deck.Shuffle();
            playerCards = new CardGroup();
            dealerCards = new CardGroup();
            IsRunning = true;
        }

        /// <summary>
        ///     At the start of a game of Blackjack, deal two cards to the dealer's hand and two cards to the player's hand, alternating the distribution of the cards between the two.
        ///     Initializes the hands of the player and the dealer for a game of Blackjack
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        ///     If the dealer's face-up card is an Ace, offer the player insurance before revealing their hole card.
        ///     The player can then take insurance or decline it.
        /// </summary>
        /// <returns></returns>
        public bool OfferPlayerInsurance()
        {
            if (dealerCards != null && dealerCards.NumCards == 2)
            {
                if (dealerCards.GetCard(1).GetValue() == 10)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///     Dealer checks hole card to see if they have blackjack.
        ///     If they have blackjack, the hand ends immediately and the player also loses unless they have blackjack (hand is a tie).
        /// </summary>
        /// <returns></returns>
        public bool CheckDealerCardsForBlackjack()
        {
            if (dealerCards != null && dealerCards.NumCards == 2 && dealerCards.GetHandValue() == 21)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Dealer checks hole card to see if they have blackjack.
        ///     If they have blackjack, the hand ends immediately and the player also loses unless they have blackjack (hand is a tie).
        /// </summary>
        /// <returns></returns>
        public bool CheckPlayerCardsForBlackjack()
        {
            if (playerCards != null && playerCards.GetHandValue() == 21)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Deals another card to the player's hand if the player chooses to hit.
        /// </summary>
        public void PlayerHit()
        {
            if (playerCards.NumCards <= 52)
            {
                playerCards.AddToDeck(deck.DealTopCard());
            }
        }

        /// <summary>
        ///     Deals another card to the dealer's hand
        /// </summary>
        public void DealerHit()
        {
            if (dealerCards.NumCards <= 52)
            {
                dealerCards.AddToDeck(deck.DealTopCard());
            }
        }

        /// <summary>
        ///     Check if the player busted or not.
        /// </summary>
        /// <returns></returns>
        public bool PlayerBust()
        {
            if (playerCards.GetHandValue() > 21)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Check if the dealer busted or not.
        /// </summary>
        /// <returns></returns>
        public bool DealerBust()
        {
            if (dealerCards.GetHandValue() > 21)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        ///     Ends player's turn when they choose to stand.
        /// </summary>
        public void PlayerChoosesToStand()
        {
            // Player has finished their turn, now it's the dealer's turn
            while (dealerCards.GetHandValue() < 17)
            {
                // Dealer must hit until their hand value is at least 17
                dealerCards.AddToDeck(deck.DealTopCard());
            }
        }

        /// <summary>
        ///     Determines who won the current game of Blackjack.
        /// </summary>
        /// <returns></returns>
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
            if (playerHandValue == dealerHandValue && playerHandValue < 21 && dealerHandValue < 21)
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

        /// <summary>
        ///     TODO for later.
        /// </summary>
        /// <returns></returns>
        public bool CanSplit()
        {
            if (playerCards.NumCards == 2 && playerCards.GetCard(1).Face == playerCards.GetCard(2).Face)
            {
                // The player can split if they have two cards of the same rank
                return true;
            }
            return false;
        }
    }
}
