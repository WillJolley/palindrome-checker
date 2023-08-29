using System;
using Palindrome.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // Get the word from the user.
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        // Check if the word is a palindrome.
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Print the result.
        if (isPalindrome)
        {
            Console.WriteLine("The word \"" + word + "\" is a palindrome.");
        }
        else
        {
            Console.WriteLine("The word \"" + word + "\" is not a palindrome.");
        }
    }
}