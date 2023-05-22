using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Xml.Linq;

namespace ExamMain
{
    /// <summary>
    /// Interaction logic for WorkWithDb.xaml
    /// </summary>
    public partial class WorkWithDb : Window
    {
        public Person PersonEdit { get; set; }
        public WorkWithDb()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            if (PersonEdit != null)
            {
                using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
                {
                    Person person = new Person();
                    person.Id = PersonEdit.Id;
                    person.FullName = bFullname.Text;
                    person.Email = bEmail.Text;
                    person.DateOfBirth = (DateTime)bYear.SelectedDate;
                    person.Phone = bPhone.Text;
                    person.Admin = (bool)checker.IsChecked;
                    person.Password = bPassword.Text;
                    person.SecretWord = bSecretWord.Text;

                    bse.Person.Attach(PersonEdit);
                    bse.Person.Remove(PersonEdit);
                    bse.SaveChanges();

                    bse.Person.Add(person);
                    bse.SaveChanges();
                }
            }
            else
            {
                using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
                {
                    Person person = new Person();
                    person.FullName = bFullname.Text;
                    person.Email = bEmail.Text;
                    person.DateOfBirth = (DateTime)bYear.SelectedDate;
                    person.Phone = bPhone.Text;
                    person.Admin = (bool)checker.IsChecked;
                    person.Password = bPassword.Text;
                    person.SecretWord = bSecretWord.Text;
                    bse.Person.Add(person);
                    bse.SaveChanges();
                }
            }
            this.Close();
        }

        private void LoadedNow(object sender, RoutedEventArgs e)
        {
            if (PersonEdit != null)
            {
                bFullname.Text = PersonEdit.FullName;
                bEmail.Text = PersonEdit.Email;
                bYear.SelectedDate = PersonEdit.DateOfBirth;
                bPhone.Text = PersonEdit.Phone;
                if(PersonEdit.Admin == true)
                {
                    checker.IsChecked = true;
                }
                else
                {
                    checker.IsChecked = false;
                }
                bPassword.Text = PersonEdit.Password;
                bSecretWord.Text = PersonEdit.SecretWord;
            }
        }
    }
}
