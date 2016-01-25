using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class PointsAwarded
    {
        public string player1OutCome;
        public string player2OutCome;
        

        public enum Points
        {
            Win = 10,
            Tie = 5,
            Loss = 2
        }

        public PointsAwarded(string player1OutCome, string player2OutCome)
        {
            this.player1OutCome = player1OutCome;
            this.player2OutCome = player2OutCome;
            
        }

        public string pointsAwardedPlayer1()
        {
            if (this.player1OutCome == "Player1 Wins!")
            {
                int player1Points = (int)Points.Win;
                string player1Score = player1Points.ToString();
                return player1Score;
            }

            else if (this.player1OutCome == "Player2 Wins!")
            {
                int player1Points = (int)Points.Loss;
                string player1Score = player1Points.ToString();
                return player1Score;
            }

            else
            {
                int player1Points = (int)Points.Tie;
                string player1Score = player1Points.ToString();
                return player1Score;
            }
        }

        public string pointsAwardedPlayer2()
        {
            if (this.player1OutCome == "Player2 Wins!")
            {
                int player2Points = (int)Points.Win;
                string player2Score = player2Points.ToString();
                return player2Score;
            }

            else if (this.player2OutCome == "Player1 Wins!")
            {
                int player2Points = (int)Points.Loss;
                string player2Score = player2Points.ToString();
                return player2Score;
            }

            else
            {
                int player2Points = (int)Points.Tie;
                string player2Score = player2Points.ToString();
                return player2Score;
            }
        }
    }
}
