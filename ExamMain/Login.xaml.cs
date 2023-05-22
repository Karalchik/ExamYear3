using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ExamMain
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Close();
            this.Close();
        }

        private void ForgotPasswordClick(object sender, RoutedEventArgs e)
        {
            RemindPassword remind=new RemindPassword();
            this.Hide();
            remind.ShowDialog();
            this.Show();
        }

        private void txtEmailChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void txtPasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void LoginInForm(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities dv = new Exam_PersonsEntities())
            {
                var query = from Person in dv.Person where Person.Email.Contains(txtBoxAddress.Text) && Person.Password.Contains(txtBoxPassword.Password) select Person;
                if (query.Count() > 0 && txtBoxAddress.Text!="" && txtBoxPassword.Password!="")
                {
                    this.Close();
                    ((MainWindow)Application.Current.MainWindow).UserNowAdmin=query.First().Admin;
                    ((MainWindow)Application.Current.MainWindow).Show();
                }
                else
                {
                    MessageBox.Show("Your Data is Incorect!");
                }
            }
        }

        private void OpenRegister(object sender, RoutedEventArgs e)
        {
            Regist reg=new Regist();
            this.Hide();
            reg.ShowDialog();
            this.Close();
            ((MainWindow)Application.Current.MainWindow).Show();
        }
    }
}
