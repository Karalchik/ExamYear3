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
    /// Interaction logic for Reg_Log.xaml
    /// </summary>
    public partial class Reg_Log : Window
    {
        private bool _lock1;
        private bool _lock2;
        private bool _lock3;
        public Reg_Log()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Close();
            this.Close();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                var query1 = bse.Person.Where(x => x.Email == txtBoxAddress.Text && x.Password == txtBoxPassword.Password);
                if (query1.ToList().Count > 0)
                {
                    ((MainWindow)Application.Current.MainWindow).PlayerW = new Player(txtBoxNickname.Text, txtBoxAddress.Text, txtBoxPassword.Password);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data isn't correct");
                }
            }
        }
        private void txtEmailChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < txtBoxAddress.Text.Length; i++)
            {
                if (txtBoxAddress.Text[i] == '@' && txtBoxAddress.Text.Length > 6)
                {
                    _lock1 = true;
                    if (_lock1 == true && _lock2 == true && _lock3 == true)
                    {
                        btnLogIn.IsEnabled = true;
                    }
                    break;
                }
                else
                {
                    btnLogIn.IsEnabled = false;
                    _lock1 = false;
                }
            }
        }

        private void txtNicknameChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxNickname.Text.Length > 1)
            {
                _lock2=true;
                if (_lock1 == true && _lock2 == true && _lock3 == true)
                {
                    btnLogIn.IsEnabled = true;
                }
            }
            else
            {
                btnLogIn.IsEnabled = false;
                _lock2 = false;
            }
        }

        private void txtPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtBoxPassword.Password.Length > 5)
            {
                _lock3 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true)
                {
                    btnLogIn.IsEnabled = true;
                }
            }
            else
            {
                btnLogIn.IsEnabled = false;
                _lock3 = false;
            }
        }
    }
}
