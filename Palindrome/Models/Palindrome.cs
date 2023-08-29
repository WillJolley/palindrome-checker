using System;

public class PalindromeChecker
{
  public static bool IsPalindrome(string word)
  {
    word inputword , as.character
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    string reversedWord = new string(chars);
    return word == reversedWord;
  }
}

// namespace Palindrome.Models
// {
//   public class Word
//   {
//     private string _word;
//     public string Word
//     {
//       get {return _word; }
//     }
    
//     public Word(string theWord)
//     {
//       _word = theWord;
//     }
//   }
// }