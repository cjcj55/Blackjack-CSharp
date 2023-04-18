namespace Blackjack
{
    partial class Test
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPlayBlackjack = new System.Windows.Forms.Button();
            this.testTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(52, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 50);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Run Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPlayBlackjack
            // 
            this.btnPlayBlackjack.Location = new System.Drawing.Point(1002, 347);
            this.btnPlayBlackjack.Name = "btnPlayBlackjack";
            this.btnPlayBlackjack.Size = new System.Drawing.Size(150, 50);
            this.btnPlayBlackjack.TabIndex = 1;
            this.btnPlayBlackjack.Text = "Play Blackjack";
            this.btnPlayBlackjack.UseVisualStyleBackColor = true;
            this.btnPlayBlackjack.Click += new System.EventHandler(this.btnPlayBlackjack_Click);
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(52, 91);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.ReadOnly = true;
            this.testTextBox.Size = new System.Drawing.Size(1100, 212);
            this.testTextBox.TabIndex = 2;
            this.testTextBox.Text = "";
            this.testTextBox.TextChanged += new System.EventHandler(this.testTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 140);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(158, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 140);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.btnPlayBlackjack);
            this.Controls.Add(this.btnTest);
            this.Name = "Test";
            this.Text = "Test Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTest;
        private Button btnPlayBlackjack;
        private RichTextBox testTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}