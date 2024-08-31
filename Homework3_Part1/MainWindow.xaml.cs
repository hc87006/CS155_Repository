/// Homework No.3 Exercise No.1 
/// File Name:     PigLatinTranslator.cs 
/// @author:       Haydn Christian
/// Date:          Sep. 9, 2024
///  
/// Problem Statement: Translate name into Pig Latin using GUI 
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. Have text boxes prompting for first and last name
/// 2. Get inputs and convert them into Pig Latin
/// 3. Output Pig Latin first and last name into seperate text blocks
/// 
/// Classes needed and Purpose (PigLatinTranslator) 
/// main class - PigLatinTranslator 
using System.Windows;
using System.Windows.Input;

namespace Homework3_Part1
{
    public partial class PigLatinTranslator : Window
    {
        private void firstName_KeyDown(object sender, KeyEventArgs e)
        /// Get KeyDown input from first name text box (to check for enter key press)
        {
            string englishFirstName = firstNameInputBox.Text;
            /// Get first name from first name text box and assign it to englishFirstName string

            if (e.Key == Key.Enter)
            /// Check if key pressed is enter key (else do nothing)
            
            {
                if (firstNameInputBox.Text.Length > 1)
                /// Check if string is at least 2 characters (else display "Please enter at least 2 characters" in text block
                
                {
                    string pigLatinFirstName = englishFirstName.Substring(1, 1).ToUpper() + englishFirstName.Substring(2) + englishFirstName.Substring(0, 1).ToLower() + "ay";
                    /// Assemble Pig Latin name from English name by:
                    ///   1. Take the second letter and capitalize it (A)
                    ///   2. Add the rest of the letters after the second one in lower-case (ydn)
                    ///   3. Move the first letter to the end and make it lower-case (h)
                    ///   4. Add ay to the end (A+ydn+h+ay / Aydnhay)
                    
                    firstNameOutputBlock.Text = pigLatinFirstName;
                } 
                
                else

                {
                    firstNameOutputBlock.Text = "Please enter at least 2 characters";
                }
            }
        }

        private void lastNameInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            string englishLastName = lastNameInputBox.Text;

            if (e.Key == Key.Enter)

            {
                if (lastNameInputBox.Text.Length > 1)

                {
                    string pigLatinLastName = englishLastName.Substring(1, 1).ToUpper() + englishLastName.Substring(2) + englishLastName.Substring(0, 1).ToLower() + "ay";
                    lastNameOutputBlock.Text = pigLatinLastName;
                }

                else

                {
                    lastNameOutputBlock.Text = "Please enter at least 2 characters";
                }

                /// Same as first name
            }
        }
    }
}