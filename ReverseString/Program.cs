using System;
using System.Text;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("------------------------------------------");
           Console.Write("Please enter a string to be analyzed: ");

           string userInput = Console.ReadLine().ToLower();
           string reverseInput = Reverse(userInput).ToLower();
           bool isInputPalindrome = isPalindrome(userInput, reverseInput);

           Console.WriteLine("------------------------------------------");
           Console.WriteLine($"String entered: {userInput}"); 
           Console.WriteLine($"String reversed: {reverseInput}");
           Console.WriteLine($"String is a Palindrome: {isInputPalindrome}");
           Console.WriteLine("------------------------------------------");
           Console.WriteLine("Press enter to exit");
           Console.ReadLine();
           
        }
        public static string Reverse(string word)
        {
            char[] strArr = word.ToCharArray();
            Array.Reverse(strArr);
            string wordReversed = new String(strArr);
            return wordReversed;
        }

        public static bool isPalindrome(string input, string reverseInput)
        {
            return input.Equals(reverseInput);
        }
    }

}