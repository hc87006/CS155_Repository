namespace Homework9_Lab1
{
    public class Program
    {
        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }

            return false;
        }

        public static void Main(string[] args)
        {
            Email email1 = new Email("aaron@example.com", "bob@example.com", "Title1", "This is the text of Email 1.");
            Email email2 = new Email("charlie@example.com", "dan@example.com", "Title2", "This is the text of Email 2.");

            File file1 = new File("/path/to/file1", "This is the content of file 1.");
            File file2 = new File("/path/to/file2", "This is the content of file 2.");

            Console.WriteLine(ContainsKeyword(email1, "text"));
            Console.WriteLine(ContainsKeyword(email2, "and"));
            Console.WriteLine(ContainsKeyword(file1, "content"));
            Console.WriteLine(ContainsKeyword(file2, "or"));
        }
    }
}