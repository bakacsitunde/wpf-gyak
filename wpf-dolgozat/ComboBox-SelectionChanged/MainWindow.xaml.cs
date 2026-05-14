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

namespace ComboBox_SelectionChanged
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

        private void cbNyelvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtValasztott != null)
            {
                var kijeloltElem = cbNyelvek.SelectedItem as ComboBoxItem;

                if (kijeloltElem != null)
                {
                    txtValasztott.Text = "Kiválasztva: " + kijeloltElem.Content.ToString();
                }
            }
        }

    }
}