using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

[TestClass]
public class PalindromeCheckerTests
{
    [TestMethod]
    public void IsPalindrome_EmptyString_ReturnsTrue()
    {
        // Arrange
        string word = "";

        // Act
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Assert
        Assert.IsTrue(isPalindrome);
    }

    [TestMethod]
    public void IsPalindrome_SingleCharacterString_ReturnsTrue()
    {
        // Arrange
        string word = "a";

        // Act
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Assert
        Assert.IsTrue(isPalindrome);
    }

    [TestMethod]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        // Arrange
        string word = "racecar";

        // Act
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Assert
        Assert.IsTrue(isPalindrome);
    }

    [TestMethod]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse()
    {
        // Arrange
        string word = "hello";

        // Act
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Assert
        Assert.IsFalse(isPalindrome);
    }
}