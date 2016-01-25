using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class HardModeUserInput
    {
        public string HMplayerOneChoice;
        public string HMplayerTwoChoice;

        public HardModeUserInput( string HMplayerOneChoice, string HMplayerTwoChoice)
        {
            this.HMplayerOneChoice = HMplayerOneChoice;
            this.HMplayerTwoChoice = HMplayerTwoChoice;
        }

        public string convertPlayer1Info()
        {
            if (HMplayerOneChoice == "1")
            {
                string HMplayer1Hand = "Rock";
                return HMplayer1Hand;
            }

            else if (HMplayerOneChoice == "2")
            {
                string HMplayer1Hand = "Paper";
                return HMplayer1Hand;
            }

            else if (HMplayerOneChoice == "3")
            {
                string HMplayer1Hand = "Scissors";
                return HMplayer1Hand;
            }

            else if (HMplayerOneChoice == "4")
            {
                string HMplayer1Hand = "Lizard";
                return HMplayer1Hand;
            }

            else if (HMplayerOneChoice == "5")
            {
                string HMplayer1Hand = "Spock";
                return HMplayer1Hand;
            }

            else
            {
                string HMplayer1Hand = "Rock";
                return HMplayer1Hand;
            }
        }
        public string convertPlayer2Info()
        {
            if (HMplayerTwoChoice == "1")
            {
                string HMplayer2Hand = "Rock";
                return HMplayer2Hand;
            }

            else if (HMplayerTwoChoice == "2")
            {
                string HMplayer2Hand = "Paper";
                return HMplayer2Hand;
            }

            else if (HMplayerTwoChoice == "3")
            {
                string HMplayer2Hand = "Scissors";
                return HMplayer2Hand;
            }

            else if (HMplayerTwoChoice == "4")
            {
                string HMplayer2Hand = "Lizard";
                return HMplayer2Hand;
            }

            else if (HMplayerTwoChoice == "5")
            {
                string HMplayer2Hand = "Spock";
                return HMplayer2Hand;
            }

            else
            {
                string HMplayer2Hand = "Rock";
                return HMplayer2Hand;
            }
        
        }


    }
}
