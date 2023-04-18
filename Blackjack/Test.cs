namespace Blackjack
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnPlayBlackjack_Click(object sender, EventArgs e)
        {
            var blackjackBoard = new Blackjack();
            blackjackBoard.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CardGroup deck = new CardGroup();
            deck.MakeWholeDeck();
            testTextBox.Text = deck.ToString();

            deck.Shuffle();
            testTextBox.Text += "\nShuffled " + deck.ToString();

            Card card = deck.DealTopCard();
            deck.AddToDeck(card);
            testTextBox.Text += "\nRemove top card and add to deck; " + deck.ToString();

            string tenthCard = deck.GetCard(10).FileName();
            string penultimateCard = deck.GetCard(51).FileName();

            pictureBox1.Image = Image.FromFile(tenthCard);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(penultimateCard);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}