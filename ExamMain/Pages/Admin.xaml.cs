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

namespace ExamMain.Pages
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void UpLoad(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities dv = new Exam_PersonsEntities())
            {
                var query = dv.Person.OrderBy(x => x.Id);
                dgv.ItemsSource = query.ToList();
                var query2 = dv.Stats.OrderBy(x => x.Id);
                dgv2.ItemsSource = query2.ToList();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                int i = (dgv.SelectedItem as Person).Id;
                Person person = bse.Person.First(x => x.Id == i);
                bse.Person.Attach(person);
                bse.Person.Remove(person);
                bse.SaveChanges();
                var query = bse.Person.OrderBy(x => x.Id).ToList();
                dgv.ItemsSource = query;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            WorkWithDb w = new WorkWithDb();
            ((MainWindow)Application.Current.MainWindow).Hide();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                int i = (dgv.SelectedItem as Person).Id;
                Person person = bse.Person.First(x => x.Id == i);
                w.PersonEdit = person;
            }
            w.ShowDialog();
            ((MainWindow)Application.Current.MainWindow).Show();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                var query = bse.Person.OrderBy(x => x.Id).ToList();
                dgv.ItemsSource = query;
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WorkWithDb w = new WorkWithDb();
            ((MainWindow)Application.Current.MainWindow).Hide();
            w.ShowDialog();
            ((MainWindow)Application.Current.MainWindow).Show();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                var query = bse.Person.OrderBy(x => x.Id).ToList();
                dgv.ItemsSource = query;
            }
        }

        private void EditSmall_Click(object sender, RoutedEventArgs e)
        {
            WorkWithDbSmall w = new WorkWithDbSmall();
            ((MainWindow)Application.Current.MainWindow).Hide();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                int i = (dgv2.SelectedItem as Stats).Id;
                Stats stats = bse.Stats.First(x => x.Id == i);
                w.StatsEdit = stats;
            }
            w.ShowDialog();
            ((MainWindow)Application.Current.MainWindow).Show();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                var query = bse.Stats.OrderBy(x => x.Id).ToList();
                dgv2.ItemsSource = query;
            }
        }

        private void DeleteSmall_Click(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                int i = (dgv2.SelectedItem as Stats).Id;
                Stats stats = bse.Stats.First(x => x.Id == i);
                bse.Stats.Attach(stats);
                bse.Stats.Remove(stats);
                bse.SaveChanges();
                var query = bse.Stats.OrderBy(x => x.Id).ToList();
                dgv2.ItemsSource = query;
            }
        }

        private void AddSmall_Click(object sender, RoutedEventArgs e)
        {
            WorkWithDbSmall ws = new WorkWithDbSmall();
            ((MainWindow)Application.Current.MainWindow).Hide();
            ws.ShowDialog();
            ((MainWindow)Application.Current.MainWindow).Show();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                var query = bse.Stats.OrderBy(x => x.Id).ToList();
                dgv2.ItemsSource = query;
            }
        }
    }
}
