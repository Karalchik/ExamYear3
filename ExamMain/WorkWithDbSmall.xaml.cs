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
    /// Interaction logic for WorkWithDbSmall.xaml
    /// </summary>
    public partial class WorkWithDbSmall : Window
    {
        public Stats StatsEdit { get; set; }
        public WorkWithDbSmall()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            if (StatsEdit != null)
            {
                using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
                {
                    Stats stats = new Stats();
                    stats.Id=StatsEdit.Id;
                    stats.NickName = bNickname.Text;
                    stats.MaxScore = Convert.ToInt32(bMaxScore.Text);
                    stats.LastScore = Convert.ToInt32(bLastScore.Text);
                    stats.PersonId = Convert.ToInt32(bPersonId.Text);

                    bse.Stats.Attach(StatsEdit);
                    bse.Stats.Remove(StatsEdit);
                    bse.SaveChanges();

                    bse.Stats.Add(stats);
                    bse.SaveChanges();
                }
            }
            else
            {
                using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
                {
                    Stats stats = new Stats();
                    stats.NickName = bNickname.Text;
                    stats.MaxScore = Convert.ToInt32(bMaxScore.Text);
                    stats.LastScore = Convert.ToInt32(bLastScore.Text);
                    stats.PersonId = Convert.ToInt32(bPersonId.Text);
                    bse.Stats.Add(stats);
                    bse.SaveChanges();
                }
            }
            this.Close();
        }

        private void LoadedNow(object sender, RoutedEventArgs e)
        {
            if (StatsEdit != null)
            {
                bNickname.Text = StatsEdit.NickName;
                bMaxScore.Text = StatsEdit.MaxScore.ToString();
                bLastScore.Text = StatsEdit.LastScore.ToString();
                bPersonId.Text = StatsEdit.PersonId.ToString();
            }
        }
    }
}
