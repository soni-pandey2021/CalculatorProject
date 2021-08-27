using System;
using System.Collections.Generic;
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

namespace calculator2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long input;
        long result;
        string operation = "";
        string prev_op = "";
        string expr = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 0;
            txtDisplay.Text = input.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 1;
            txtDisplay.Text = input.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 2;
            txtDisplay.Text = input.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 3;
            txtDisplay.Text = input.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 4;
            txtDisplay.Text = input.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 5;
            txtDisplay.Text = input.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 6;
            txtDisplay.Text = input.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 7;
            txtDisplay.Text = input.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 8;
            txtDisplay.Text = input.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            input = (input * 10) + 9;
            txtDisplay.Text = input.ToString();
        }

        private void evaluate(string op)
        {
            switch (op)
            {
                case "+":
                    result = (result + input);
                    break;

                case "-":
                    result = (result - input);
                    break;

                case "*":
                    result = (result * input);
                    break;

                case "/":
                    result = (result / input);
                    break;
                case "":
                    result = input;
                    break;
            }
            txtDisplay.Text = (result).ToString();
            if (op == "=")
            {
                expr = result.ToString() + operation;
            }
            else
            {
                expr = expr + input.ToString() + operation;
            }
            txtDisplay2.Text = expr;
            input=0;
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            prev_op = operation;
            operation = "+";
            evaluate(prev_op);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            prev_op = operation;
            operation = "-";
            evaluate(prev_op);
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            prev_op = operation;
            operation = "*";
            evaluate(prev_op);
        }

        private void btnDivi_Click(object sender, RoutedEventArgs e)
        {
            prev_op = operation;
            operation = "/";
            evaluate(prev_op);
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            prev_op = operation;
            operation = "=";
            evaluate(prev_op);
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            input = 0;
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            input = 0;
            result = 0;
            prev_op = "";
            operation = "";
            expr = "";
            txtDisplay.Text = "0";
            txtDisplay2.Text = "";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            input = (input / 10);
            txtDisplay.Text = input.ToString();            
        }

        private void btnPositiveNegtive_Click(object sender, RoutedEventArgs e)
        {
            input *= -1;
            txtDisplay.Text = input.ToString();
        }

    }
}
