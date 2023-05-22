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

namespace ExamMain
{
    /// <summary>
    /// Interaction logic for Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        private bool _lock1;
        private bool _lock2;
        private bool _lock3;
        private bool _lock4;
        private bool _lock5;
        private bool _lock6;
        private bool AdminLock;
        public Regist()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Login login= new Login();
            this.Hide();
            login.Show();
            this.Close();
            
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            using(Exam_PersonsEntities db=new Exam_PersonsEntities())
            {

                Person person = new Person();
                person.Admin = AdminLock;
                person.SecretWord = txtBoxSecret.Text;
                person.Password = txtBoxPassword.Password;
                person.DateOfBirth = (DateTime)dpBirth.SelectedDate;
                person.Email = txtBoxAddress.Text;
                person.FullName = txtBoxFullName.Text;
                person.Phone = txtNumber.Text;
                db.Person.Add(person);
                db.SaveChanges();
                ((MainWindow)Application.Current.MainWindow).UserNowAdmin = person.Admin;
            }
            this.Close(); 
        }

        private void txtEmailChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < txtBoxAddress.Text.Length; i++)
            {
                if (txtBoxAddress.Text[i] == '@' && txtBoxAddress.Text.Length > 6)
                {
                    _lock1 = true;
                    if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4==true && _lock5==true && _lock6==true)
                    {
                        btnRegister.IsEnabled = true;
                    }
                    break;
                }
                else
                {
                    btnRegister.IsEnabled = false;
                    _lock1 = false;
                }
            }
        }

        private void txtFullNameChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxFullName.Text.Length > 6)
            {
                _lock2 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4 == true && _lock5 == true && _lock6 == true)
                {
                    btnRegister.IsEnabled = true;
                }
            }
            else
            {
                btnRegister.IsEnabled = false;
                _lock2 = false;
            }
        }

        private void txtPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtBoxPassword.Password.Length > 5)
            {
                _lock3 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4 == true && _lock5 == true && _lock6 == true)
                {
                    btnRegister.IsEnabled = true;
                }
            }
            else
            {
                btnRegister.IsEnabled = false;
                _lock3 = false;
            }
        }

        private void txtSecretChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxSecret.Text.Length > 2)
            {
                _lock5 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4 == true && _lock5 == true && _lock6 == true)
                {
                    btnRegister.IsEnabled = true;
                }
            }
            else
            {
                btnRegister.IsEnabled = false;
                _lock5 = false;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checker.IsChecked == true)
            {
                stackHide.Visibility = Visibility.Visible;
            }
            else
            {
                stackHide.Visibility = Visibility.Hidden;
            }
        }

        private void txtNumberChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNumber.Text.Length > 6)
            {
                _lock4 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4 == true && _lock5 == true && _lock6 == true)
                {
                    btnRegister.IsEnabled = true;
                }
            }
            else
            {
                btnRegister.IsEnabled = false;
                _lock4 = false;
            }
        }

        private void CheckForAdmin(object sender, TextChangedEventArgs e)
        {
            if (txtAdminPass.Text == "admin")
            {
                AdminLock = true;
            }
            else
            {
                AdminLock = false;
            }
        }

        private void dpBirthChaged(object sender, SelectionChangedEventArgs e)
        {
            if (dpBirth.SelectedDate != null)
            {
                _lock6 = true;
                if (_lock1 == true && _lock2 == true && _lock3 == true && _lock4 == true && _lock5 == true && _lock6 == true)
                {
                    btnRegister.IsEnabled = true;
                }
            }
            else
            {
                btnRegister.IsEnabled = false;
                _lock6 = false;
            }
        }
    }
}
