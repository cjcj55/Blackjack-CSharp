using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Blackjack : Form
    {
        private BlackjackGame blackjackGame;
        private Score score;
        private static string cardBackUrl = Path.Combine(Application.StartupPath, "Resources", "cards", "BicycleBack.png");
        public Blackjack()
        {
            InitializeComponent();
            PlayBlackjackRound();

            score = new Score();
            blackjackGame = new BlackjackGame();
            blackjackGame.DealCards();

            deckPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "cards", "BicycleBackStack.png"));
            deckPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PopulateInitialPictureBoxes();
            UpdateScore();

            CheckForBlackjack();
        }

        /// <summary>
        ///     Checks if the user has blackjack or if the dealer has blackjack.
        ///     If both have blackjack, TIE! and nobody wins.
        /// </summary>
        /// <returns> @true if one or more people has blackjack</returns>
        private bool CheckForBlackjack()
        {
            if (blackjackGame.CheckPlayerCardsForBlackjack() && !blackjackGame.CheckDealerCardsForBlackjack())
            {
                System.Diagnostics.Debug.WriteLine("Player wins!");
                PopulatePictureBoxes();
                score.IncrementPlayerWins();
                UpdateScore();
                hitButton.Enabled = false;
                playAgainButton.Visible = true;
                standButton.Enabled = false;
                return true;
            }

            if (blackjackGame.CheckDealerCardsForBlackjack() && !blackjackGame.CheckPlayerCardsForBlackjack())
            {
                System.Diagnostics.Debug.WriteLine("Player loses!");
                PopulatePictureBoxes();
                score.IncrementDealerWins();
                UpdateScore();
                hitButton.Enabled = false;
                playAgainButton.Visible = true;
                standButton.Enabled = false;
                return true;
            }

            if (blackjackGame.CheckDealerCardsForBlackjack() && blackjackGame.CheckPlayerCardsForBlackjack())
            {
                System.Diagnostics.Debug.WriteLine("Tie!");
                PopulatePictureBoxes();
                score.IncrementTies();
                UpdateScore();
                hitButton.Enabled = false;
                playAgainButton.Visible = true;
                standButton.Enabled = false;
                return true;
            }

            return false;
        }

        /// <summary>
        ///     Simple loop that checks if the player wants to play 5 more rounds of Blackjack or not.
        ///     Backbone for running multiple rounds of Blackjack within one application window.
        /// </summary>
        private void PlayBlackjackRound()
        {
            
        }

        /// <summary>
        ///     At beginning of a round, populates the PictureBoxes for the player's hand and dealer's hand.
        /// </summary>
        private void PopulateInitialPictureBoxes()
        {
            LoadCardsIntoPictureBox(blackjackGame.dealerCards, dealerDeckPictureBox, true);
            LoadCardsIntoPictureBox(blackjackGame.playerCards, userDeckPictureBoxSingle, false);
        }

        /// <summary>
        ///     Populates the PictureBoxes for the player's hand and dealer's hand.
        /// </summary>
        private void PopulatePictureBoxes()
        {
            LoadCardsIntoPictureBox(blackjackGame.dealerCards, dealerDeckPictureBox, false);
            LoadCardsIntoPictureBox(blackjackGame.playerCards, userDeckPictureBoxSingle, false);
        }

        /// <summary>
        ///     Populates the PictureBoxes for a hand (either dealer's or player's).
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="pictureBox"></param>
        /// <param name="isDealer"></param>
        private void LoadCardsIntoPictureBox(CardGroup hand, PictureBox pictureBox, bool isDealer)
        {
            // Clear the PictureBox control before loading new cards
            pictureBox.Image = null;

            // Loop through the cards in the hand and create a new Bitmap for each one
            int x = 0;
            foreach (Card card in hand.GetCards())
            {
                if (card != null)
                {
                    Bitmap cardImage;

                    if (isDealer && x == 0)
                    {
                        cardImage = new Bitmap(cardBackUrl);
                    }
                    else
                    {
                        cardImage = new Bitmap(card.FileName());
                    }
                    // Scale down the card image to fit the PictureBox control
                    float scale = (float)pictureBox.Height / cardImage.Height;
                    int newWidth = (int)(cardImage.Width * scale);
                    int newHeight = (int)(cardImage.Height * scale);
                    Bitmap resizedCardImage = new Bitmap(newWidth, newHeight);
                    using (Graphics g = Graphics.FromImage(resizedCardImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(cardImage, new Rectangle(Point.Empty, resizedCardImage.Size));
                    }

                    // Position the card images horizontally with some spacing between them
                    resizedCardImage.SetResolution(128, 128);
                    Graphics g2 = Graphics.FromImage(resizedCardImage);
                    //g2.DrawString(card.GetValue().ToString(), new Font("Arial", 16), Brushes.Black, new PointF(5, 5));
                    g2.Flush();
                    g2.Dispose();

                    pictureBox.Image = CombineBitmap((Bitmap)pictureBox.Image, resizedCardImage, new Point(x, 0));
                    x += resizedCardImage.Width - 30; // add spacing between cards
                }
            }
        }

        /// <summary>
        ///     Combines the bitmaps to add more card images to a hand that is being displayed.
        /// </summary>
        /// <param name="bmp1"></param>
        /// <param name="bmp2"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static Bitmap CombineBitmap(Bitmap bmp1, Bitmap bmp2, Point offset)
        {
            if (bmp1 == null)
            {
                return bmp2;
            }

            Bitmap bmp3 = new Bitmap(bmp1.Width + bmp2.Width, Math.Max(bmp1.Height, bmp2.Height));
            using (Graphics g = Graphics.FromImage(bmp3))
            {
                g.DrawImage(bmp1, new Point(0, 0));
                g.DrawImage(bmp2, offset);
            }
            return bmp3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            blackjackGame.PlayerHit();
            PopulateInitialPictureBoxes();
            CheckForBlackjack();
            if (blackjackGame.PlayerBust())
            {
                PopulatePictureBoxes();
                score.IncrementDealerWins();
                UpdateScore();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                playAgainButton.Visible = true;
                System.Diagnostics.Debug.WriteLine("Player loses!  Player has: " + blackjackGame.playerCards.GetHandValue() + ", Dealer has: " + blackjackGame.dealerCards.GetHandValue());
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            hitButton.Enabled = false;
            standButton.Enabled = false;

            //blackjackGame.PlayerChoosesToStand();

            while (blackjackGame.dealerCards.GetHandValue() < 17)
            {

                // Dealer must hit until their hand value is at least 17
                blackjackGame.DealerHit();
            }

            CheckForBlackjack();
            if (blackjackGame.DealerBust())
            {
                System.Diagnostics.Debug.WriteLine("Dealer busted!  Player wins!  Player has: " + blackjackGame.playerCards.GetHandValue() + ", Dealer has: " + blackjackGame.dealerCards.GetHandValue());
            }

            int winner = blackjackGame.CalculateWinner();

            if (winner == 1)
            {
                // Player wins
                score.IncrementPlayerWins();
                System.Diagnostics.Debug.WriteLine("Player wins!  Player has: " + blackjackGame.playerCards.GetHandValue() + ", Dealer has: " + blackjackGame.dealerCards.GetHandValue());
            } else if (winner == -1)
            {
                // Dealer wins
                score.IncrementDealerWins();
                System.Diagnostics.Debug.WriteLine("Player loses!  Player has: " + blackjackGame.playerCards.GetHandValue() + ", Dealer has: " + blackjackGame.dealerCards.GetHandValue());
            } else
            {
                // Tie
                score.IncrementTies();
                System.Diagnostics.Debug.WriteLine("Tie!  Player has: " + blackjackGame.playerCards.GetHandValue() + ", Dealer has: " + blackjackGame.dealerCards.GetHandValue());
            }

            // System.Diagnostics.Debug.WriteLine("Player's Score: " + score.ToString());

            PopulatePictureBoxes();
            UpdateScore();
            playAgainButton.Visible = true;
        }

        private void UpdateScore()
        {
            playerScore.Text = score.GetPlayerWins().ToString();
            dealerScore.Text = score.GetDealerWins().ToString();
            tieScore.Text = score.GetTies().ToString();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            playAgainButton.Visible = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;

            PlayBlackjackRound();

            blackjackGame = new BlackjackGame();
            blackjackGame.DealCards();

            // deckPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "cards", "BicycleBackStack.png"));
            // deckPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PopulateInitialPictureBoxes();

            CheckForBlackjack();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            // Create a copy of the collection
            List<Form> openForms = Application.OpenForms.Cast<Form>().ToList();

            // Iterate over the copy and close each form
            foreach (Form form in openForms)
            {
                form.Close();
            }

            // Exit the application
            Application.Exit();
        }
    }
}
