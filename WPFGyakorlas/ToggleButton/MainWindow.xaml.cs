using System.Windows;

namespace WPFToggleButtonControl
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

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            text2.Text = "Button is Checked";
            text2.Background = new SolidColorBrush(Colors.LightGreen); 
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            text2.Text = "Button is unchecked.";
            text2.Background = new SolidColorBrush(Colors.LightCoral);
        }

    }
}