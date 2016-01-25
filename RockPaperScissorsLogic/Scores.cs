using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissorsLogic
{
    public class Scores
    {
        public string playerOneUsername;
        public string playerTwoUsername;
        public string playerOneScore;
        public string playerTwoScore;

        
        public Scores(string playerOneUsername, string playerTwoUsername, string playerOneScore, string playerTwoScore)
        {
            this.playerOneUsername = playerOneUsername;
            this.playerTwoUsername = playerTwoUsername;
            this.playerOneScore = playerOneScore;
            this.playerTwoScore = playerTwoScore;

        }

        public string concatStringsP1()
        {
            string player1Info = playerOneUsername + ": " + playerOneScore;
            return player1Info;
        }

        public string concatStringsP2()
        {
            string player2Info = playerTwoUsername + ": " + playerTwoScore;
            return player2Info;
        }


        public void saveHighScores(string player1Info, string player2Info)
        {
            StreamWriter tw = new StreamWriter("Scores.txt", true);
            tw.WriteLine(player1Info);
            tw.WriteLine(player2Info);
            tw.Close();
        }

        
    }
}
