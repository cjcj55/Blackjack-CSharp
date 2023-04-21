namespace Blackjack
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userDeckPictureBoxSingle = new System.Windows.Forms.PictureBox();
            this.deckPictureBox = new System.Windows.Forms.PictureBox();
            this.dealerDeckPictureBox = new System.Windows.Forms.PictureBox();
            this.DealerCardsLabel = new System.Windows.Forms.Label();
            this.PlayerCardsLabel = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.tieScore = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDeckPictureBoxSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDeckPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userDeckPictureBoxSingle
            // 
            this.userDeckPictureBoxSingle.Location = new System.Drawing.Point(166, 422);
            this.userDeckPictureBoxSingle.Name = "userDeckPictureBoxSingle";
            this.userDeckPictureBoxSingle.Size = new System.Drawing.Size(1000, 175);
            this.userDeckPictureBoxSingle.TabIndex = 0;
            this.userDeckPictureBoxSingle.TabStop = false;
            // 
            // deckPictureBox
            // 
            this.deckPictureBox.Location = new System.Drawing.Point(50, 233);
            this.deckPictureBox.Name = "deckPictureBox";
            this.deckPictureBox.Size = new System.Drawing.Size(100, 150);
            this.deckPictureBox.TabIndex = 1;
            this.deckPictureBox.TabStop = false;
            // 
            // dealerDeckPictureBox
            // 
            this.dealerDeckPictureBox.Location = new System.Drawing.Point(166, 39);
            this.dealerDeckPictureBox.Name = "dealerDeckPictureBox";
            this.dealerDeckPictureBox.Size = new System.Drawing.Size(1000, 175);
            this.dealerDeckPictureBox.TabIndex = 2;
            this.dealerDeckPictureBox.TabStop = false;
            // 
            // DealerCardsLabel
            // 
            this.DealerCardsLabel.AutoSize = true;
            this.DealerCardsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DealerCardsLabel.Location = new System.Drawing.Point(5, 93);
            this.DealerCardsLabel.Name = "DealerCardsLabel";
            this.DealerCardsLabel.Size = new System.Drawing.Size(155, 30);
            this.DealerCardsLabel.TabIndex = 3;
            this.DealerCardsLabel.Text = "Dealer\'s Cards:";
            // 
            // PlayerCardsLabel
            // 
            this.PlayerCardsLabel.AutoSize = true;
            this.PlayerCardsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerCardsLabel.Location = new System.Drawing.Point(26, 474);
            this.PlayerCardsLabel.Name = "PlayerCardsLabel";
            this.PlayerCardsLabel.Size = new System.Drawing.Size(124, 30);
            this.PlayerCardsLabel.TabIndex = 4;
            this.PlayerCardsLabel.Text = "Your Cards:";
            this.PlayerCardsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hitButton.Location = new System.Drawing.Point(166, 603);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(100, 50);
            this.hitButton.TabIndex = 5;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.standButton.Location = new System.Drawing.Point(293, 603);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(100, 50);
            this.standButton.TabIndex = 6;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(487, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(632, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dealer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(776, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tie";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerScore.Location = new System.Drawing.Point(509, 315);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(25, 30);
            this.playerScore.TabIndex = 11;
            this.playerScore.Text = "0";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dealerScore.Location = new System.Drawing.Point(655, 315);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(25, 30);
            this.dealerScore.TabIndex = 12;
            this.dealerScore.Text = "0";
            // 
            // tieScore
            // 
            this.tieScore.AutoSize = true;
            this.tieScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tieScore.Location = new System.Drawing.Point(793, 315);
            this.tieScore.Name = "tieScore";
            this.tieScore.Size = new System.Drawing.Size(25, 30);
            this.tieScore.TabIndex = 13;
            this.tieScore.Text = "0";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.Location = new System.Drawing.Point(1023, 603);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(143, 50);
            this.playAgainButton.TabIndex = 14;
            this.playAgainButton.Text = "Play Again?";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitBtn.Location = new System.Drawing.Point(1156, 12);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(96, 50);
            this.quitBtn.TabIndex = 15;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.tieScore);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.PlayerCardsLabel);
            this.Controls.Add(this.DealerCardsLabel);
            this.Controls.Add(this.dealerDeckPictureBox);
            this.Controls.Add(this.deckPictureBox);
            this.Controls.Add(this.userDeckPictureBoxSingle);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.userDeckPictureBoxSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDeckPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox userDeckPictureBoxSingle;
        private PictureBox deckPictureBox;
        private PictureBox dealerDeckPictureBox;
        private Label DealerCardsLabel;
        private Label PlayerCardsLabel;
        private Button hitButton;
        private Button standButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label playerScore;
        private Label dealerScore;
        private Label tieScore;
        private Button playAgainButton;
        private Button quitBtn;
    }
}