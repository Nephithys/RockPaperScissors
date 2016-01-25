using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RockPaperScissorsLogic;

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for HardModePVP.xaml
    /// </summary>
    public partial class HardModePVP : Window
    {
        public HardModePVP()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HardModePvPReults myPvPResults = new HardModePvPReults(PlayerOneHMPVP.Password, PlayerTwoHMPVP.Password);
            string win = myPvPResults.hardModePvPWinner();
            string lose = myPvPResults.hardModePvPLoser(win);

            PointsAwarded myPoints = new PointsAwarded(win, lose);
            string player1Points = myPoints.pointsAwardedPlayer1();
            string player2Points = myPoints.pointsAwardedPlayer2();
            string p1Username = Player1Username.Text;
            string p2Username = Player2Username.Text;

            Scores myScore = new Scores(p1Username, p2Username, player1Points, player2Points);
            string p1Info = myScore.concatStringsP1();
            string p2Info = myScore.concatStringsP2();
            myScore.saveHighScores(p1Info, p2Info);

        }   
    }
}
