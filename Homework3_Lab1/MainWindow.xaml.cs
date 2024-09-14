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

namespace OutstandingMortgage
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

        private void BalanceTextBox_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (BalanceTextBox.Text.All(char.IsDigit))
                {
                    const double interest = 6.39;
                    double balance = double.Parse(BalanceTextBox.Text);
                    double payment = double.Parse(PaymentTextBox.Text);

                    double interestPaid = Math.Round((balance * interest) / 12);

                    double principal = Math.Round((payment - interestPaid), 2);

                    double balanceRemaining = Math.Round((balance - principal), 2);

                    NewBalance.Text = balanceRemaining.ToString();
                    Principal.Text = principal.ToString();
                    InterestPaid.Text = interestPaid.ToString();
                    
                }

                
            }
        }

    }
}