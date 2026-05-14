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

namespace Feladat2
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

        private void Uzenet_TextChanged(object sender, TextChangedEventArgs e)
        {
            int hossz = txtUzenet.Text.Length;
            txtKarszam.Text = $"{hossz}/200";


            txtKarszam.Foreground = hossz >= 200 ? Brushes.Red : Brushes.Gray;


        }
    }
}