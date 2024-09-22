/// Homework No.4  Exercise No.3
/// File Name:     SpeedingTicket.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 21, 2024
///  
/// Problem Statement: Calculate the speeding fine at MiraCosta
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Get speed from text box
/// 2. Calculate fine 
/// 3. Change text color depending on penalty
/// 
/// Classes needed and Purpose (SpeedingTicket : Window) 
/// main class - SpeedingTicket : Window
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Homework4_Lab1
{
    public partial class SpeedingTicket : Window
    {
        public SpeedingTicket()
        {
            InitializeComponent();
        }

        private void SpeedBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (SpeedBox.Text.All(char.IsDigit) && SpeedBox.Text != "")
                {
                    SpeedValue.Text = SpeedBox.Text;
                    SpeedCheckBox.IsChecked = true;
                }

            }
        }
        /// if enter is pressed and input is all digits, set SpeedValue box to input and check checkbox
        

        private void LimitBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (LimitBox.Text.All(char.IsDigit) && LimitBox.Text != "")
                {
                    LimitValue.Text = LimitBox.Text;
                    LimitCheckBox.IsChecked = true;
                }
            }
        }
        /// same as above

        private void CalculateFineButton_Click(object sender, RoutedEventArgs e)
        {
            int totalFine;
            int speed, limit;
            /// define speed, limit, and totalFine variables

            speed = 0;
            limit = 0;
            /// assign 0 as default
            
            if (SpeedValue.Text != "")
            {
                speed = Int32.Parse(SpeedValue.Text);
            }
            /// update speed to input
            
            if (LimitValue.Text != "")
            {
                limit = Int32.Parse(LimitValue.Text);
            }
            /// same as above
            
            totalFine = (speed - limit) * 7;
            /// fine per mph over speed limit

            if ((speed - limit) > 24)
            {
                totalFine += 310;
                FineDisplay.Foreground = new SolidColorBrush(Colors.Red);
            }
            /// if speed is more than 25 over the limit, add 310 (250 for being 25 over plus 60 for base fine) and change text color to red

            else if ((speed - limit) > 0)
            {
                totalFine += 60;
                FineDisplay.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            /// if speed is over the limit, add 60 and change color to yellow

            else
            {
                FineDisplay.Foreground = new SolidColorBrush(Colors.Green);
            }
            /// if speed is not over limit, change color to green
            
            FineDisplay.Text = "Fine: " + totalFine;
            /// display fine total
        }
    }
}