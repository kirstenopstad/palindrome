using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class CheckerTests
  {
    [TestMethod]
    // Test methods will go here
    public void IsPalindrome_StringIsPalindrome_True()
    {
      string userInput = "ana";
      Checker checker = new Checker();
      Assert.AreEqual(true, checker.IsPalindrome(userInput));
    }

    [TestMethod]
    public void IsPalindrome_StringIsNotPalindrome_False()
    {
      string userInput = "nana";
      Checker checker = new Checker();
      Assert.AreEqual(false, checker.IsPalindrome(userInput));
    }
    [TestMethod]
    public void IsPalindrome_CaseSensitiveStringIsPalindrome_True()
    {
      string userInput = "aNana"; // anaNa
      Checker checker = new Checker();
      Assert.AreEqual(true, checker.IsPalindrome(userInput));
    }
    [TestMethod]
    public void IsPalindrome_CaseSensitiveStringIsNotPalindrome_False()
    {
      string userInput = "nAna"; // anAn
      Checker checker = new Checker();
      Assert.AreEqual(false, checker.IsPalindrome(userInput));
    }
    
    [TestMethod]
    public void IsPalindrome_NumStringIsPalindrome_False()
    {
      string userInput = "322"; // 223
      Checker checker = new Checker();
      Assert.AreEqual(false, checker.IsPalindrome(userInput));
    }

    [TestMethod]
    public void IsPalindrome_NumStringIsNotPalindrome_True()
    {
      string userInput = "323"; // 323
      Checker checker = new Checker();
      Assert.AreEqual(true, checker.IsPalindrome(userInput));
    }
  }
}