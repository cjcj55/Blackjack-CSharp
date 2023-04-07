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
            this.btnPlayBlackjack.Location = new System.Drawing.Point(602, 367);
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
            this.testTextBox.Size = new System.Drawing.Size(700, 250);
            this.testTextBox.TabIndex = 2;
            this.testTextBox.Text = "";
            this.testTextBox.TextChanged += new System.EventHandler(this.testTextBox_TextChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.btnPlayBlackjack);
            this.Controls.Add(this.btnTest);
            this.Name = "Test";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTest;
        private Button btnPlayBlackjack;
        private RichTextBox testTextBox;
    }
}