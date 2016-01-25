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
    /// Interaction logic for HardModePVE.xaml
    /// </summary>
    public partial class HardModePVE : Window
    {
        public HardModePVE()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ArtificialIntelligence AI = new ArtificialIntelligence();
            string aiInt = AI.generatedAINumber();
            HardModePvPReults myPvPResults = new HardModePvPReults(SinglePlayerChoice1.Text, aiInt);
            string win = myPvPResults.hardModePvPWinner();
            string lose = myPvPResults.hardModePvPLoser(win);

            PointsAwarded myPoints = new PointsAwarded(win, lose);
            string player1Points = myPoints.pointsAwardedPlayer1();
            string player2Points = myPoints.pointsAwardedPlayer2();
            string p1Username = SinglePlayerUsername.Text;
            string p2AI = "AI";
            

            Scores myScore = new Scores(p1Username, p2AI, player1Points, player2Points);
            string p1Info = myScore.concatStringsP1();
            string p2Info = myScore.concatStringsP2();
            
            myScore.saveHighScores(p1Info, p2Info);

            Winner.Text = win;
            Loser.Text = lose;
            ChoiceResultP1.Text = SinglePlayerChoice1.Text;
            ChoiceResultP2.Text = aiInt;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
            this.Close();
        }
    }
}
