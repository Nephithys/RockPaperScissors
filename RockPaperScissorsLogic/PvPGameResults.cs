using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class PvPGameResults
    {
        public int player1sChoiceAsInt;
        public int player2sChoiceAsInt;
        

        public PvPGameResults(int player1sChoiceAsInt, int player2sChoiceAsInt)
        {
            this.player1sChoiceAsInt = player1sChoiceAsInt;
            this.player2sChoiceAsInt = player2sChoiceAsInt;
            
        }

        public string whoWins()
        {
            if ((player1sChoiceAsInt == 2 && player2sChoiceAsInt == 1) || (player1sChoiceAsInt == 3 && player2sChoiceAsInt == 2) || (player1sChoiceAsInt == 1 && player2sChoiceAsInt == 3))
            {
                string winner = "Player1";
                return winner;
            }

            else if ((player2sChoiceAsInt == 2 && player1sChoiceAsInt == 1) || (player2sChoiceAsInt == 3 && player1sChoiceAsInt == 2) || (player2sChoiceAsInt == 1 && player1sChoiceAsInt == 3))
            {
                string winner = "Player2";
                return winner;
            }

            else
            {
                string winner = "Tie";
                return winner;
            }
        }
    }
}
