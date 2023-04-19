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
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}