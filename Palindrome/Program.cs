using System;
using Palindrome.Models;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to see if it is a palindrome!");
      string input = Console.ReadLine();
      Checker checkWord = new Checker();
      bool result = checkWord.IsPalindrome(input);
      Console.WriteLine("Is " + input + " a palindrome? " + result);
    }
  }
}