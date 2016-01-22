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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for PvPWin.xaml
    /// </summary>
    public partial class PvPWin : Window
    {
        string winner;
        public PvPWin(string winner)
        {
            InitializeComponent();
            this.winner = winner;
            TheWinnerIsText.Text = winner;
            
        }

        private void TheWinnerIsText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
