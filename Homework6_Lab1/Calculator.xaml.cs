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