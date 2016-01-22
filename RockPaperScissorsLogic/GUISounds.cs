using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLogic
{
    public class GUISounds
    {
        public void posterNose()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("SParty.wav");
            player.Play();
            
        }
    }
}
