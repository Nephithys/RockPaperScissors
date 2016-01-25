using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class HardModePvPReults
    {
        public string player1Choice;
        public string player2Choice;

        public HardModePvPReults(string player1Choice, string player2Choice)
        {
            this.player1Choice = player1Choice;
            this.player2Choice = player2Choice;
        }

        public string hardModePvPWinner()
        {
            if ((this.player1Choice == "1" && this.player2Choice == "3" || this.player2Choice == "4") ||
                (this.player1Choice == "2" && this.player2Choice == "1" || this.player2Choice == "5") ||
                (this.player1Choice == "3" && this.player2Choice == "2" || this.player2Choice == "4") ||
                (this.player1Choice == "4" && this.player2Choice == "2" || this.player2Choice == "5") ||
                (this.player1Choice == "5" && this.player2Choice == "1" || this.player2Choice == "3"))
            {
                string winner = "Player1 Wins!";
                return winner;
            }
            else if ((this.player2Choice == "1" && this.player1Choice == "3" || this.player1Choice == "4") ||
                (this.player2Choice == "2" && this.player1Choice == "1" || this.player1Choice == "5") ||
                (this.player2Choice == "3" && this.player1Choice == "2" || this.player1Choice == "4") ||
                (this.player2Choice == "4" && this.player1Choice == "2" || this.player1Choice == "5") ||
                (this.player2Choice == "5" && this.player1Choice == "1" || this.player1Choice == "3"))
            {
                string winner = "Player2 Wins!";
                return winner;
            }
            else
            {
                string winner = "Both Tied!";
                return winner;
            }
 
        }

        public string hardModePvPLoser(string winner)
        {
            if (winner == "Player1 Wins!")
            {
                string loser = "Player2 Lost :c";
                return loser;
            }

            else if (winner == "Player2 Wins!")
            {
                string loser = "Player1 Lost :c";
                return loser;
            }

            else
            {
                string loser = "Both Tied!";
                return loser;
            }
        }
    }
}
