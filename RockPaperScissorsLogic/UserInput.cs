using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class UserInput
    {
        public string player1Choice;
        public string player2Choice;
        


        public UserInput(string player1Choice, string player2Choice)
        {
            this.player1Choice = player1Choice;
            this.player2Choice = player2Choice;   
        }

        public int p1Choice()
        {

            if (this.player1Choice == "Rock" || this.player1Choice == "rock")
            {
                int p1Hand = 1;
                return p1Hand;
            }

            else if (this.player1Choice == "Paper" || this.player1Choice == "paper")
            {
                int p1Hand = 2;
                return p1Hand;
            }


            else if (this.player1Choice == "Scissors" || this.player1Choice == "scissors")
            {
                int p1Hand = 3;
                return p1Hand;
            }

            else
            {
                int p1Hand = 1;
                return p1Hand;
            }

            
        }

        public int p2Choice()
        {

            if (this.player2Choice == "Rock" || this.player2Choice == "rock")
            {
                int p2Hand = 1;
                return p2Hand;
            }

            else if (this.player2Choice == "Paper" || this.player2Choice == "paper")
            {
                int p2Hand = 2;
                return p2Hand;
            }


            else if (this.player2Choice == "Scissors" || this.player2Choice == "scissors")
            {
                int p2Hand = 3;
                return p2Hand;
            }

            else
            {
                int p2Hand = 1;
                return p2Hand;
            }

        }
    }
}
