using System;
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
        public Blackjack()
        {
            InitializeComponent();

            blackjackGame = new BlackjackGame();
            blackjackGame.DealCards();

            deckPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "cards", "BicycleBackStack.png"));
            deckPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            populatePictureBoxes();

        }

        private void populatePictureBoxes()
        {
            LoadCardsIntoPictureBox(blackjackGame.dealerCards, dealerDeckPictureBox);
            LoadCardsIntoPictureBox(blackjackGame.playerCards, userDeckPictureBoxSingle);
        }

        private void LoadCardsIntoPictureBox(CardGroup hand, PictureBox pictureBox)
        {
            // Clear the PictureBox control before loading new cards
            pictureBox.Image = null;

            // Loop through the cards in the hand and create a new Bitmap for each one
            int x = 0;
            foreach (Card card in hand.GetCards())
            {
                if (card != null)
                {
                    Bitmap cardImage = new Bitmap(card.FileName());

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
    }
}
