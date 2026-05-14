using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModálisAblak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
    private void btnMegnyit_Click(object sender, RoutedEventArgs e)
        {
            BeallitasokWindow ablak = new BeallitasokWindow();

            if (ablak.ShowDialog() == true)
            {
                txtAllapot.Text = "Beállítások elmentve!";
            }
            else
            {
                txtAllapot.Text = "Ablak bezárva mentés nélkül.";
            }
        }
    } 
}