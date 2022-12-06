using System;
using System.Collections.Generic;

namespace Palindrome.Models
{
  public class Checker
  {
    public bool IsPalindrome(string userInput)
    {
      string capsInput = userInput.ToUpper();
      char[] arrayUserInput = capsInput.ToCharArray();
      List<char> arrayReversed = new List<char>{};
      
      for (int i = arrayUserInput.Length - 1; i >= 0 ; i--)
      {
        arrayReversed.Add(arrayUserInput[i]);
      }
      string word = new string(arrayReversed.ToArray());
      
      if (word == capsInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
