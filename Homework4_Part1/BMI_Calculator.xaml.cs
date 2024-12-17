/// Homework No.4  Exercise No.1
/// File Name:     BMI_Calculator.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 21, 2024
///  
/// Problem Statement: use inputted height and weight to calculate BMI 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Get height and weight from text boxes
/// 2. Calculate and display BMI
/// 3. Change color depending on below, in, or above healthy BMI range
/// 
/// Classes needed and Purpose (BMI_Calculator : Window) 
/// main class - BMI_Calculator : Window  
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Homework4_Part1
{
    public partial class BMI_Calculator : Window
    {
        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void WeightBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            /// if enter key is pressed on the weight input box
            {
                if (WeightBox.Text.All(char.IsDigit))
                /// if all characters inputted are numbers
                {
                    WeightValue.Text = WeightBox.Text;
                    /// debugging text block (currently hidden) / also used as value for calculation
                    WeightCheck.IsChecked = true;
                    /// update checkbox to true
                }
            }
        }

        private void HeightBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (HeightBox.Text.All(char.IsDigit))
                {
                    HeightValue.Text = HeightBox.Text;
                    HeightCheck.IsChecked = true;
                }
            }
        }
        /// same as above

        private void WeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WeightCheck.IsChecked = false;
            WeightValue.Text = "0";
        }
        /// clear value and uncheck check box if text box text is changed

        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            HeightCheck.IsChecked = false;
            HeightValue.Text = "0";
        }
        /// same as above

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            bool heightCheckBool = (bool) HeightCheck.IsChecked;
            bool weightCheckBool = (bool) WeightCheck.IsChecked;
            /// if checkbox is checked / input is confirmed

            double height = double.Parse(HeightValue.Text);
            double weight = double.Parse(WeightValue.Text);
            /// assign values to height and weight

            if (heightCheckBool && weightCheckBool == true)
            {
                double BMI = Math.Round(((weight * 702) / (height * height)), 2);
                /// math for bmi calculation

                if (BMI <15)
                {
                    BMI_Display.Foreground = new SolidColorBrush(Colors.Blue);
                }
                /// if BMI is less than 15 -> change color to blue

                else if (BMI > 15 && BMI < 26)
                {
                    BMI_Display.Foreground = new SolidColorBrush(Colors.Green);
                }
                /// if BMI is more than 15 and less than 26 -> change color to green

                else if (BMI > 26)
                {
                    BMI_Display.Foreground = new SolidColorBrush(Colors.Gold);
                }
                /// if BMI is more than 26 -> change color to gold (it was easier to see than yellow)

                BMI_Display.Text = BMI.ToString();
                /// display BMI
            }
        }
    }
}