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

            blackjackGame= new BlackjackGame();
        }
    }
}
