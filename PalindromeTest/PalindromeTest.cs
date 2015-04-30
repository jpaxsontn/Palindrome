using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        private IPalindromeDomain palindromeDomain;

        public void Setup()
        {
            palindromeDomain = new PalindromeDomain();
        }

        [TestMethod]
        public void PalindromeDomain_Should_Return_True_For_A_Simple_Palindrome_Sentence_With_No_Punctuation_And_Even_Number_Of_Words_Same_Case()
        {
            //Arrange
            Setup();
            var testString = "sex at noon taxes";

            //Act
            var isPalindrome = palindromeDomain.IsPalindrome(testString);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void PalindromeDomain_Should_Return_True_For_A_Simple_Palindrome_Sentence_With_No_Punctuation_And_Even_Number_Of_Words_Mixed_Case()
        {
            //Arrange
            Setup();
            var testString = "Sex at noon taxes";

            //Act
            var isPalindrome = palindromeDomain.IsPalindrome(testString);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void PalindromeDomain_Should_Return_True_For_A_Simple_Palindrome_Sentence_With_Punctuation_And_Even_Number_Of_Words_And_Mixed_Case()
        {
            //Arrange
            Setup();
            var testString = "I, man, am regal; a German am I.";

            //Act
            var isPalindrome = palindromeDomain.IsPalindrome(testString);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void PalindromeDomain_Should_Return_True_For_A_Simple_Palindrome_Sentence_With_Odd_Number_Of_Words()
        {
            //Arrange
            Setup();
            var testString = "Noel sees Leon.";

            //Act
            var isPalindrome = palindromeDomain.IsPalindrome(testString);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void PalindromDomain_Should_Return_False_For_A_Sentence_That_Is_Not_A_Palindrome()
        {
            //Arrange
            Setup();
            var testString = "This sentence is not a palindrome!";

            //Act
            var isPalindrome = palindromeDomain.IsPalindrome(testString);

            //Assert
            Assert.IsFalse(isPalindrome);
        }
    }
}
