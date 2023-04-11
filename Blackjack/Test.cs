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

            testTextBox.Text += "\nImages for 10th and penultimate cards: " + deck.GetCard(10).FileName() + " and " + deck.GetCard(51).FileName();
        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}