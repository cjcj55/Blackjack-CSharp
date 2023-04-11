using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Score
    {
        private int playerWins;
        private int dealerWins;

        public Score()
        {
            playerWins = 0;
            dealerWins = 0;
        }

        public void IncrementPlayerWins()
        {
            playerWins++;
        }

        public void IncrementDealerWins()
        {
            dealerWins++;
        }

        public int GetPlayerWins()
        {
            return playerWins;
        }

        public int GetDealerWins()
        {
            return dealerWins;
        }
    }

}
