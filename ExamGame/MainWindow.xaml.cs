using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace ExamGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Player PlayerW { get; set; }
        public Stats NowStats { get; set; }
        internal StatsOfPlayer Stats { get; set; }

        DispatcherTimer gameTimer = new DispatcherTimer();
        List<Ellipse> remove = new List<Ellipse>();

        int spawnRate = 60;
        int currentRate;
        int lastScore = 0;
        int maxScore = 0;
        int health = 350;
        int posX;
        int posY;
        int score = 0;
        bool pause = false;
        bool start = false;
        string path = "D:\\StatsOfPlayers"; 

        double growMode = 0.6;

        Random rand = new Random();

        MediaPlayer playClickSound = new MediaPlayer();
        MediaPlayer playerPopSound = new MediaPlayer();

        Uri ClickSound;
        Uri PoppedSound;

        Brush brush;

        public MainWindow()
        {
            InitializeComponent();
            DirectoryInfo directory = new DirectoryInfo(path);
            if(!directory.Exists )
            {
                directory.Create();
            }
            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();

            currentRate = spawnRate;
            ClickSound = new Uri("C:\\Users\\msi\\source\\repos\\ExamMain\\ExamGame\\sound\\clickedpop.mp3");
            PoppedSound = new Uri("C:\\Users\\msi\\source\\repos\\ExamMain\\ExamGame\\sound\\pop.mp3");

        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (start == true)
            {
            txtBlockScore.Text = "Score: " + score;
            txtBlockLastScore.Text = "LastScore: " + lastScore;
            txtBlockMaxScore.Text = "MaxScore: " + maxScore;
            currentRate -= 2;
            if (currentRate < 1)
            {
                currentRate = spawnRate;
                posX = rand.Next(15, 700);
                posY = rand.Next(50, 340);

                brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255), (byte)rand.Next(1, 255), (byte)rand.Next(1, 255)));

                Ellipse circle = new Ellipse
                {
                    Tag = "circle",
                    Height = 10,
                    Width = 10,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = brush
                };

                Canvas.SetLeft(circle, posX);
                Canvas.SetTop(circle, posY);

                myCanvas.Children.Add(circle);
            }

            foreach(var x in myCanvas.Children.OfType<Ellipse>())
            {
                x.Height += growMode;
                x.Width += growMode;
                x.RenderTransformOrigin = new Point(0.5, 0.5);
                if (x.Width > 50)
                {
                    remove.Add(x);
                    health -= 35;
                    playerPopSound.Open(PoppedSound);
                    playerPopSound.Play();
                }
            }

            if (health > 0)
            {
                HealthBar.Width = health;
            }
            else
            {
                HealthBar.Width = 1;
                GameOver();
            }
            foreach(Ellipse i in remove)
            {
                myCanvas.Children.Remove(i);
            }
            if (score > 5)
            {
                spawnRate = 25;
            }
            if (score > 20)
            {
                spawnRate = 35;
                growMode = 1.5;
                }

            }
        }

        private void clickCanvas(object sender, MouseButtonEventArgs e)
        {
            if(e.OriginalSource is Ellipse)
            {
                Ellipse circle = (Ellipse)e.OriginalSource;

                myCanvas.Children.Remove(circle);

                score++;

                playClickSound.Open(ClickSound);
                playClickSound.Play();

            }
        }

        private void GameOver()
        {
            start = false;
            Pause.IsEnabled = false;
            Start.IsEnabled = true;
            gameTimer.Stop();
            MessageBox.Show("GameOver" + Environment.NewLine + "Your Score: " + score + Environment.NewLine + "Click ok to play again", "Game Over");
            foreach(var y in myCanvas.Children.OfType<Ellipse>())
            {
                remove.Add(y);
            }
            foreach (Ellipse i in remove)
            {
                myCanvas.Children.Remove(i);
            }
            growMode = 0.6;
            spawnRate = 60;
            lastScore = score;
            if (lastScore > maxScore)
            {
                maxScore = lastScore;
            }
            score = 0;
            currentRate = 5;
            health = 350;
            Stats = new StatsOfPlayer(lastScore, maxScore);
            using (StreamWriter sw = new StreamWriter(path+$"/player{PlayerW.Nickname}___{PlayerW.Address}.txt",false))
            {
                sw.WriteLine(PlayerW.Nickname);
                sw.WriteLine(PlayerW.Address);
                sw.WriteLine(PlayerW.Password);
                sw.WriteLine(Stats.LastScore);
                sw.WriteLine(Stats.MaxScore);
                sw.WriteLine(DateTime.Now);
            }
            txtBlockScore.Text = "Score: " + score;
            txtBlockLastScore.Text = "LastScore: " + lastScore;
            txtBlockMaxScore.Text = "MaxScore: " + maxScore;
            NowStats = new Stats();
            using (Exam_PersonsEntities bse = new Exam_PersonsEntities())
            {
                int i = 0;
                Stats stats = new Stats();
                stats.NickName = PlayerW.Nickname;
                stats.MaxScore = Stats.MaxScore;
                stats.LastScore = Stats.LastScore;

                var query = bse.Stats.Where(x => x.NickName == NowStats.NickName);
                var query1 = bse.Person.Where(x => x.Email == PlayerW.Address && x.Password == PlayerW.Password);
                if (query1.ToList().Count > 0)
                {
                    i=query1.First().Id;
                    NowStats.PersonId = i;
                }
                else
                {
                    NowStats.PersonId = query.First().PersonId;
                }
                if (query.ToList().Count > 0)
                {
                    stats.Id = NowStats.Id;
                    bse.Stats.Attach(NowStats);
                    bse.Stats.Remove(NowStats);
                    bse.SaveChanges();

                    bse.Stats.Add(stats);
                    bse.SaveChanges();
                }
                else
                {
                    bse.Stats.Add(stats);
                    bse.SaveChanges();
                }
            }

            remove.Clear();
            gameTimer.Start();
        }

        private void showScore(object sender, RoutedEventArgs e)
        {
            PlayerStats stats = new PlayerStats();
            if (pause == true)
            {
                this.Hide();
                stats.ShowDialog();
                this.Show();
            }
            else
            {
                pauseGame(sender, e); 
                this.Hide();
                stats.ShowDialog();
                this.Show();
                pauseGame(sender, e);
            }
        }

        private void pauseGame(object sender, RoutedEventArgs e)
        {
            if (pause == true)
            {
                pause = false;
                myCanvas.MouseLeftButtonDown += clickCanvas;
                Pause.Content = "Pause";
                gameTimer.Start();
            }
            else
            {
                pause = true;
                myCanvas.MouseLeftButtonDown -= clickCanvas;
                Pause.Content = "Resome";
                Pause.IsEnabled = true;
                gameTimer.Stop();
            }
        }

        private void startGame(object sender, RoutedEventArgs e)
        {
            start = true;
            Start.IsEnabled = false;
            Pause.IsEnabled = true;
        }

        private void LoadedTitle(object sender, RoutedEventArgs e)
        {
            Reg_Log rl = new Reg_Log();
            this.Hide();
            rl.ShowDialog();
            this.Show();
        }
    }
}
