/// Homework No.2 Exercise No.1 
/// File Name:     PigLatinTranslator.cs 
/// @author:       Haydn Christian 
/// Date:          Aug. 28, 2024
/// Problem Statement: Translate English into Pig Latin
///     
/// Overall Plan (step-by-step, how you want the code to make it happen): 
/// 1. WriteLine prompting user to input their name
/// 2. ReadLine to get user response
/// 3. Assign user inputs to firstName and lastName strings
/// 4. Use Substring, toUpper, and toLower to reconstruct the names (as shown below)
/// 
/// Classes needed and Purpose - PigLatinTranslator 
/// main class - PigLatinTranslator

using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;  
namespace Homework2Lab1
{
    class PigLatinTranslator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            /// Prompt user for name
            
            string firstName = Console.ReadLine();
            /// Assign input to firstName string
            
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            /// Same as above

            string pigLatinFirstName = firstName.Substring(1,1).ToUpper() + firstName.Substring(2) + firstName.Substring(0,1).ToLower() + "ay";
            /// Make string pigLatinFirstName (Haydn for example) by
            /// 1. Take the second letter and capitalize it (A)
            /// 2. Add the rest of the letters after the second one in lower-case (ydn)
            /// 3. Move the first letter to the end and make it lower-case (h)
            /// 4. Add ay to the end (A+ydn+h+ay / Aydnhay)
            
            string pigLatinLastName = lastName.Substring(1, 1).ToUpper() + lastName.Substring(2) + lastName.Substring(0, 1).ToLower() + "ay";
            /// Same as above (H+ristian+c+ay / Hristinacay)

            Console.WriteLine(pigLatinFirstName + " " + pigLatinLastName);
            /// Write first name, add a space, write last name

        }
    }
}