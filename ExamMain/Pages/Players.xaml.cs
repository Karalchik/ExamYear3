﻿using System;
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
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class Players : Page
    {
        public Players()
        {
            InitializeComponent();
        }

        private void UpLoal(object sender, RoutedEventArgs e)
        {
            using (Exam_PersonsEntities dv = new Exam_PersonsEntities())
            {
                var query =dv.Stats.OrderBy(x=>x.Id);
                
                dgv.ItemsSource = query.ToList();
            }
        }
    }
}
