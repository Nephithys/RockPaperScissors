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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (PvP.IsChecked == true)
            {
                PlayerVsPlayerScreen pvpWindow = new PlayerVsPlayerScreen();
                pvpWindow.Show();
                this.Close();
            }

            else if (AI.IsChecked == true)
            {
                SinglePlayerScreen aiWindow = new SinglePlayerScreen();
                aiWindow.Show();
                this.Close();
            }

            else if (PvP.IsChecked == false && AI.IsChecked == false)
            {
                SinglePlayerScreen aiWindow = new SinglePlayerScreen();
                aiWindow.Show();
                this.Close();
            }
            

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            PvP.IsChecked = true;
            AI.IsChecked = false;
        }

        private void checkBox_Checked_1(object sender, RoutedEventArgs e)
        {
            PvP.IsChecked = false;
            AI.IsChecked = true;
        }
    }
}
