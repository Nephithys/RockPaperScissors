using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class ArtificialIntelligence
    {
        public string generatedAINumber()
        {
            Random AIChoice = new Random();
            int AINum = AIChoice.Next(1, 6);
            string AINumber = AINum.ToString();
            return AINumber;
        }
    }
}
