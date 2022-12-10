using System.Windows;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {

        decimal? firstNumber = null;
        decimal? secondNumber = null;
        string? operation = null;

        public MainWindow()
        {
            
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 0;

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += 9;
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text = "";
            firstNumber = null;
            secondNumber = null;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            tblockResult.Text += ",";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(decimal.TryParse(tblockResult.Text, out decimal result))
            {
                firstNumber = result;
                tblockResult.Text = "";
                operation = "+";
            }
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(tblockResult.Text, out decimal result))
            {
                firstNumber = result;
                tblockResult.Text = "";
                operation = "-";
            }
        }

        private void btnMultiplikation_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(tblockResult.Text, out decimal result))
            {
                firstNumber = result;
                tblockResult.Text = "";
                operation = "*";
            }
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(tblockResult.Text, out decimal result))
            {
                firstNumber = result;
                tblockResult.Text = "";
                operation = "/";
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(tblockResult.Text, out decimal resultTwo))
            {
                secondNumber = resultTwo;
                tblockResult.Text = "";
                switch (operation)
                {
                    case "+":
                        tblockResult.Text = (firstNumber + secondNumber).ToString();
                        secondNumber = null;
                        operation = null;

                        break;
                    case "-":
                        tblockResult.Text = (firstNumber - secondNumber).ToString();
                        secondNumber = null;
                        operation = null;
                        break;
                    case "*":
                        tblockResult.Text = (firstNumber * secondNumber).ToString();
                        secondNumber = null;
                        operation = null;
                        break;
                    case "/":
                        if(secondNumber != 0)
                        {
                            tblockResult.Text = (firstNumber / secondNumber).ToString();
                            secondNumber = null;
                            operation = null;
                        }
                        else
                        {
                            MessageBox.Show("Nie dzieliny przez zero");
                            firstNumber = null;
                            secondNumber = null;
                            operation = null;
                        }
                        break;

                }

            }
            
        }
    }
}