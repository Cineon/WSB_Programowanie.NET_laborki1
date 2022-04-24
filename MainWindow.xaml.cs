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

namespace WPF_Calculator_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number_1 = 0;
        long number_2 = 0;
        string operation = "";

       
       


        public MainWindow()
        {
            InitializeComponent();
        }




        //1 Button 
        private void FirstBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 1;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 1;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //2 Button
        private void SecondBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 2;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 2;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //3 Button
        private void ThirdBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 3;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 3;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //4 Button
        private void FourthBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 4;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 4;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //5 Button
        private void FivthBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 5;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 5;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //6 Button
        private void SixthBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 6;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 6;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //7 Button
        private void SeventhBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 7;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 7;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //8 Button
        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 8;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 8;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //9 Button
        private void NinthBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10) + 9;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10) + 9;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //0 Button
        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number_1 = (number_1 * 10);
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 * 10);
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //Plus Button
        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            DisplayScreen.Text = "0";
        }
        //Minus Button
        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            DisplayScreen.Text = "0";
        }
        //Multiplication Button
        private void MultiBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            DisplayScreen.Text = "0";
        }
        //Divide Button
        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            DisplayScreen.Text = "0";
        }
        //Equals Button
        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    DisplayScreen.Text = (number_1 + number_2).ToString();
                    break;

                case "-":
                    DisplayScreen.Text = (number_1 - number_2).ToString();
                    break;

                case "*":
                    DisplayScreen.Text = (number_1 * number_2).ToString();
                    break;

                case "/":
                    // Zapobieganie dzieleniu przez zero.
                    if (number_2 == 0)

                    {
                        DisplayScreen.Text = "Error".ToString();
                    }
                    else
                    {
                        DisplayScreen.Text = (number_1 / number_2).ToString();
                    }
                    break;
            }
        }
        //Clear Entry Button
        private void CEBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number_1 = 0;
            }
            else
            {
                number_2 = 0;
            }

            DisplayScreen.Text = "0";
        }
        //Cancel Button
        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            number_1 = 0;
            number_2 = 0;
            operation = "";
            DisplayScreen.Text = "0";
        }
        //Backspace Button
        private void BSBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number_1 = (number_1 / 10);
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 = (number_2 / 10);
                DisplayScreen.Text = number_2.ToString();
            }
        }
        //Plus - MInus Button
        private void PlsMnsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number_1 *= -1;
                DisplayScreen.Text = number_1.ToString();
            }
            else
            {
                number_2 *= -1;
                DisplayScreen.Text = number_2.ToString();
            }
        }
        

    }




        
}
