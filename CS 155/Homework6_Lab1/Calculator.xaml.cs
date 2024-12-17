/// Homework No.6  Exercise No.2
/// File Name:     Calculator.xaml.cs
/// @author:       Haydn Christian
/// Date:          Oct. 5, 2024
///  
/// Problem Statement: Calculate math problems based on user input, catch /0 exception
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Get user input for left and right inputs from text boxes
/// 2. Get user input for operation type from list
/// 3. Calculate result, catch divide by 0 exception if needed
/// 
/// Classes needed and Purpose (MainWindow) 
/// main class - MainWindow

using System.Windows;

namespace Homework6_Lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int operation = OperatorList.SelectedIndex;
                decimal leftInput = Convert.ToDecimal(LeftInputBox.Text);
                decimal rightInput = Convert.ToDecimal(RightInputBox.Text);

                decimal result = 0;

                switch (operation)
                {
                    case 0:
                        result = leftInput + rightInput;
                        OutputBox.Text = result.ToString();
                        break;
                    
                    case 1:
                        result = leftInput - rightInput;
                        OutputBox.Text = result.ToString();
                        break;
                    
                    case 2:
                        result = leftInput * rightInput;
                        OutputBox.Text = result.ToString();
                        break;
                    
                    case 3:
                        result = leftInput / rightInput;
                        OutputBox.Text = result.ToString();
                        break;
                    
                    case 4:
                        result = leftInput % rightInput;
                        OutputBox.Text = result.ToString();
                        break;
                    
                    default:
                        result = 0;
                        MessageBox.Show("No operation selected");
                        break;
                }
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Can't divide by 0");
            }
        }
    }
}