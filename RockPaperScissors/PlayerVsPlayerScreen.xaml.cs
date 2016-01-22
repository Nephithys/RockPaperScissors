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
    /// Interaction logic for PlayerVsPlayerScreen.xaml
    /// </summary>
    public partial class PlayerVsPlayerScreen : Window
    {
        public PlayerVsPlayerScreen()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            UserInput pvpUserInput = new UserInput(Player1Input.Password, Player2Input.Password);
            int player1Int = pvpUserInput.p1Choice();
            int player2Int = pvpUserInput.p2Choice();

            PvPGameResults myPvPResults = new PvPGameResults(player1Int, player2Int);
            string getWinner = myPvPResults.whoWins();

            PvPWin displayWinner = new PvPWin(getWinner);
            displayWinner.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            GUISounds mySounds = new GUISounds();
            mySounds.posterNose();
        }
    }
}
