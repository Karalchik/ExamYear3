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
    /// Interaction logic for RemindPassword.xaml
    /// </summary>
    public partial class RemindPassword : Window
    {
        public string Password { get; set; }
        public RemindPassword()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckFor(object sender, RoutedEventArgs e)
        {
            txtBoxPassword.Text = Password;
        }

        private void txtSecretChanged(object sender, TextChangedEventArgs e)
        {
            using (Exam_PersonsEntities dv = new Exam_PersonsEntities())
            {
                var query = from Person in dv.Person where Person.SecretWord.Contains(txtSecret.Text) select Person;
                if (query.Count() > 0)
                {
                    btnOkey.IsEnabled = true;
                    Password = query.ToList()[0].Password;
                }
                else
                {
                }
            }
        }

        private void txtPasswordChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
