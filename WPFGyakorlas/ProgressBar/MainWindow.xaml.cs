using System.Text;
using System.Timers;
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

namespace ProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pg1.Value < pg1.Maximum)
            {
                // növelés (pl. 10 egységgel)
                pg1.Value += 1;

                // százalék kiszámítása
                double percent = (pg1.Value / pg1.Maximum) * 100;

                //txtProgress.Text = $"{percent:0}%";
            }
            else
            {
                timer.Stop();
                //txtProgress.Text = "Kész!";
            }
        }
    }
}
