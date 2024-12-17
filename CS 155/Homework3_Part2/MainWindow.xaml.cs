/// Homework No.3 Exercise No.2
/// File Name:     MainWindow.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 12, 2024
///  
/// Problem Statement: Translate name into Pig Latin using GUI 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Get user input from text box and conver it to an integer
/// 2. Use division to get the quotient and remainder from the value divided by the coin value
/// 3. Display the results
/// 
/// Classes needed and Purpose (MainWindow) 
/// main class - MainWindow 
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

namespace Homework3_Part2
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

        private void ChangeInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                if (ChangeInputBox.Text.All(char.IsDigit))
                {

                    int changeValueInt = int.Parse(ChangeInputBox.Text);
                    /// Get input from text box, covert into an integer, and assign to changeValue int

                    if (changeValueInt >= 25 && changeValueInt <= 100)
                    /// if amount is above 25 and below 100
                    {
                        int quarterAmount = changeValueInt / 25;
                        /// Get quarter amount
                        int quarterRemainder = changeValueInt % 25;
                        /// Get remainder to calculate the rest of the coins

                        int dimeAmount = quarterRemainder / 10;
                        int dimeRemainder = quarterRemainder % 10;

                        int nickelAmount = dimeRemainder / 5;

                        QuartersOutput.Text = quarterAmount.ToString();
                        DimesOutput.Text = dimeAmount.ToString();
                        NicklesOutput.Text = nickelAmount.ToString();
                        /// Convert amounts to strings and show them in the text blocks
                    }


                    else
                    {
                        ChangeInputBox.Text = "Please input a value above 25 and below 100";
                        /// Warning for inputting wrong amount
                    }
                }

            }
        }
    }
}