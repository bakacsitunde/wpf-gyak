using System;
using System.Windows;
using System.Windows.Controls; 

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (txtMeret != null && sender is System.Windows.Controls.RadioButton rb)
            {
                txtMeret.Text = "Kiválasztott méret: " + rb.Content.ToString();
            }
        }
    }
}
