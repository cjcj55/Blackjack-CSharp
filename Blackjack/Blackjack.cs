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
            PopulatePictureBoxes();

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
                score.IncrementPlayerWins();
                return true;
            }

            if (blackjackGame.CheckDealerCardsForBlackjack() && !blackjackGame.CheckPlayerCardsForBlackjack())
            {
                score.IncrementDealerWins();
                return true;
            }

            if (blackjackGame.CheckDealerCardsForBlackjack() == blackjackGame.CheckPlayerCardsForBlackjack())
            {
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
        ///     Populates the PictureBoxes for the player's hand and dealer's hand.
        /// </summary>
        private void PopulatePictureBoxes()
        {
            LoadCardsIntoPictureBox(blackjackGame.dealerCards, dealerDeckPictureBox, true);
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
            PopulatePictureBoxes();
            CheckForBlackjack();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            //blackjackGame.PlayerChoosesToStand();

            System.Diagnostics.Debug.WriteLine(blackjackGame.dealerCards.GetHandValue());


            while (blackjackGame.dealerCards.GetHandValue() < 17)
            {
                System.Diagnostics.Debug.WriteLine(blackjackGame.dealerCards.GetHandValue());

                // Dealer must hit until their hand value is at least 17
                blackjackGame.DealerHit();
                PopulatePictureBoxes();
            }
        }
    }
}
