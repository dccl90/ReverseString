using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseInput = "";
            
            Console.WriteLine("------------------------------------------");
            Console.Write("Please enter a string to be analyzed: ");
            string userInput = Console.ReadLine().ToLower();

            for(int i = 0; i < userInput.Length; i++ ){
                int index = userInput.Length - 1 -i;
                reverseInput += userInput[index];
            }

            bool isInputPalindrome = userInput.Equals(reverseInput);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"String entered: {userInput}"); 
            Console.WriteLine($"String reversed: {reverseInput}");
            Console.WriteLine($"String is a Palindrome: {isInputPalindrome}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }

}