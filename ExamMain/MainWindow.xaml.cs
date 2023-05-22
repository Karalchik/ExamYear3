using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ExamMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page Admin;
        private Page Players;
        public bool UserNowAdmin { get; set; }
        public double FrameOpacity { set; get; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Admin = new Pages.Admin();
            Players = new Pages.Players();
            FrameOpacity = 1;
            Frame.Content = Players;
        }
        private void ToAdmin_Click(object sender, RoutedEventArgs e)
        {
            SlowOpacity(Admin);
        }
        private void ToPlayers_Click(object sender, RoutedEventArgs e)
        {
            SlowOpacity(Players);
        }

        private void SlowOpacity(Page page)
        {
            for(double i = 1.0; i > 0.0; i -= 0.1)
            {
                FrameOpacity = i;
                Thread.Sleep(5);
            }
            Frame.Content = page;
            for(double i = 0.0; i < 1.1; i += 0.1)
            {
                FrameOpacity = i;
                Thread.Sleep(5);
            }
        }

        private void LoadedMain(object sender, RoutedEventArgs e)
        {
            Login l=new Login();
            this.Hide();
            l.ShowDialog();
            if (UserNowAdmin == false)
            {
                AdminBtn.Visibility = Visibility.Hidden;
                AdminBtn.Width = 0;
            }
            else
            {
                AdminBtn.Visibility = Visibility.Visible;
                AdminBtn.Width = 140;
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            SlowOpacity((Page)Frame.Content);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Regist l = new Regist();
            this.Hide();
            l.ShowDialog();
            if (UserNowAdmin == false)
            {
                AdminBtn.Visibility = Visibility.Hidden;
                AdminBtn.Width = 0;
            }
            else
            {
                AdminBtn.Visibility = Visibility.Visible;
                AdminBtn.Width = 140;
            }
        }

        private void LogIn_Clickc(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            if (UserNowAdmin == false)
            {
                AdminBtn.Visibility = Visibility.Hidden;
                AdminBtn.Width = 0;
            }
            else
            {
                AdminBtn.Visibility = Visibility.Visible;
                AdminBtn.Width = 140;
            }
        }
    }
}
