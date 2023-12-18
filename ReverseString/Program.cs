using System;
using System.Runtime.InteropServices;
using System.Text;

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

            for(int i = userInput.Length -1; i >= 0; i-- ){
                reverseInput += userInput[i];
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