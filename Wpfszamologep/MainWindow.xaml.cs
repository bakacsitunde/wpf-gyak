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

namespace Wpfszamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string szam1 = "";
        private string szam2 = "";
        private string muvelet = "";
        private string eredmeny = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberHandler(string displayText, string numberValue)
        {
            
            if (displayText == "0")
            {
                display.Text = numberValue;
            }
            else
            {
                display.Text = display.Text + numberValue;
            }
        }

        private void PointHandler(string displayText, string pointValue)
        {

            if (displayText == "0")
            {
                display.Text = display.Text + pointValue;
            }
            else
            {
                if(!displayText.Contains(pointValue))
                display.Text = display.Text + pointValue;
            }
        }

        private void OperationHandler(string displayText, string operationValue)
        {
            szam2 = display.Text;

            int value1 = Convert.ToInt32(szam1);
            int value2 = Convert.ToInt32(szam2);
            double eredmeny = 0;

            switch(operationValue)
            {
                case "+":
                    eredmeny = value1 + value2;
                    break;

                case "-":
                    eredmeny = value1 - value2;
                    break;

                case "x":
                    eredmeny = value1 * value2;
                    break;

                case "/":
                    eredmeny = value1 / value2;
                    break;

                case "%":
                //??
              
                    eredmeny = value1 % value2;
                    
                    break;
            }

            this.eredmeny = eredmeny.ToString();
        
            display.Text = this.eredmeny;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string displayText = display.Text;
            switch (btn.Content)
            {
                case "0":
                    NumberHandler(displayText,"0");
                    break;
                case "1":
                    NumberHandler(displayText, "1");
                    break;
                   
                case "2":
                    NumberHandler(displayText, "2");
                    break;

                case "3":
                    NumberHandler(displayText, "3");
                    break;

                case "4":
                    NumberHandler(displayText, "4");
                    break;

                case "5":
                    NumberHandler(displayText, "5");
                    break;

                case "6":
                    NumberHandler(displayText, "6");
                    break;

                case "7":
                    NumberHandler(displayText, "7");
                    break;

                case "8":
                    NumberHandler(displayText, "8");
                    break;

                case "9":
                    NumberHandler(displayText, "9");
                    break;

                case ",": 
                    PointHandler(displayText, ",");

                    break;
            }
        }

        private void Button_Click_Operation(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Content)
            {
                case "+":
                    szam1 = display.Text;
                    muvelet = "+";

                    display.Text = "0";
                    break;

                case "-":
                    szam1 = display.Text;
                    muvelet = "-";
                    display.Text = "0";
                    break;

                case "x":
                    szam1 = display.Text;
                    muvelet = "x";
                    break;

                case "/":
                    szam1 = display.Text;
                    muvelet = "/";
                    break;

                case "CE":
                    display.Text = "0";
                    break;

                case "C":
                    display.Text = "0";
                    break;

                case "%":
                    szam1 = display.Text;
                    muvelet = "%";
                    break;

                case "=":
                    OperationHandler(display.Text, this.muvelet);
                    break;
                
            }
        }
    }
}