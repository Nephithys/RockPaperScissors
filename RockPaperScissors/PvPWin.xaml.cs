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
    /// Interaction logic for PvPWin.xaml
    /// </summary>
    public partial class PvPWin : Window
    {
        string winner;
        string loser;
        public PvPWin(string winner, string loser)
        {
            InitializeComponent();
            this.winner = winner;
            this.loser = loser;
            TheWinnerIsText.Text = winner;
            TheLoserIsText.Text = loser;
            
        }

        private void TheWinnerIsText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TheLoserIsText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
            this.Close();
        }
    }
}
