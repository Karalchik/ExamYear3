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

namespace ExamGame
{
    /// <summary>
    /// Interaction logic for PlayerStats.xaml
    /// </summary>
    public partial class PlayerStats : Window
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        private void LoadedNow(object sender, RoutedEventArgs e)
        {
            txtNick.Text = "Nickname: " + ((MainWindow)Application.Current.MainWindow).PlayerW.Nickname;
            txtEmail.Text = "Email: " + ((MainWindow)Application.Current.MainWindow).PlayerW.Address;
            txtLast.Text = "Last Score: " + ((MainWindow)Application.Current.MainWindow).Stats.LastScore.ToString();
            txtMax.Text = "Max Score: " + ((MainWindow)Application.Current.MainWindow).Stats.MaxScore.ToString();
        }
    }
}
