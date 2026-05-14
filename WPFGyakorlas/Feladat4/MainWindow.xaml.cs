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

namespace Feladat4
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

        private void Jelszo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string j = txtJelszo.Text;
            int pont = 0;

            if (j.Length > 6) pont += 25;
            if (j.Any(c => Char.IsDigit(c))) pont += 25;
            if (j.Any(c => Char.IsUpper(c))) pont += 25;
            if (j.Any(c => "!@#$%".Contains(c))) pont += 25;

                pbErosseg.Value = pont;

            txtErosseg.Text = pont switch
            {
                0 => "Erősség: Gyenge",
                25 => "Erősség: Közepes",
                50 => "Erősség: Megfelelő",
                _ => "Erősség: Erős"
            };
        }
    }
}