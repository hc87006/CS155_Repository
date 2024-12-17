/// Homework No. 5 Exercise No. 3
/// File Name:     GuessingGame.xaml.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 24, 2024
///  
/// Problem Statement: Have the user guess a randomly generated number 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Randomly generate a number
/// 2. If user guesses higher or lower, output higher or lower respectively
/// 3. If user guesses number, congragulate them
/// 
/// Classes needed and Purpose (MainWindow : Window, RandomNumber) 
/// main class - MainWindow : Window
using System.Windows;

namespace Homework5_Lab1
{
    public partial class MainWindow : Window
    {
        private RandomNumber generatedNumber;
        // Create generatedNumber field for later use


        public MainWindow()
        // On startup
        {
            InitializeComponent();

            Random generator = new Random();
            // Create generator
            generatedNumber = new RandomNumber(generator);
            // generatedNumber field is assigned to generator
        }

        public class RandomNumber
        // Create Random number and assign value to Value int
        {
            public int Value {get;}
            // Create public Value int and get random number from generator

            public RandomNumber(Random generator)
            {
                Value = generator.Next(100);
                // Generate number and set Value to it
            }
        }

        public int guesses = 0;
        // Guess counter (not required but I wanted to challenge myself)
        
        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            if (GuessBox.Text.All(char.IsDigit) && GuessBox.Text != "")
            // If guess text box is not empty and contains only digits
            {
                int number = generatedNumber.Value;
                // Assign generated number (from Value) to number int
                int guess = int.Parse(GuessBox.Text);
                // Get user guess from text box
                
                guesses++;
                // Increment guesses on button clicked

                GuessBlock.Text = guesses.ToString();
                // Show amount of guesses

                if (guess == number)
                // If user has guessed the number
                {
                    GuessOutput.Text = "Congratulations! The number was " + number;
                }

                else if (guess < number)
                // If user guess was lower than the number
                {
                    GuessOutput.Text = "Higher";
                }

                else if (guess > number)
                // If user guess was higher than the number
                {
                    GuessOutput.Text = "Lower";
                }
            }
        }
    }
}