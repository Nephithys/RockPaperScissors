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
    /// Interaction logic for HardModeMenu.xaml
    /// </summary>
    public partial class HardModeMenu : Window
    {
        public HardModeMenu()
        {
            InitializeComponent();
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            PlayervsPlayer.IsChecked = true;
            PlayervsEnemy.IsChecked = false;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            PlayervsEnemy.IsChecked = true;
            PlayervsPlayer.IsChecked = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (PlayervsPlayer.IsChecked == true)
            {
                HardModePVP pvpWindow = new HardModePVP();
                pvpWindow.Show();
                this.Close();
            }

            else if (PlayervsEnemy.IsChecked == true)
            {
                
                HardModePVE HardModePVE = new HardModePVE();
                HardModePVE.Show();
                this.Close();
            }

            else if (PlayervsPlayer.IsChecked == false && PlayervsEnemy.IsChecked == false)
            {
                
                HardModePVE HardModePVE = new HardModePVE();
                HardModePVE.Show();
                this.Close();
            }
        }
    }
}
