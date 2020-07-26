using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project;
using NUnitTests;


namespace NUnitTests
{ 
    [TestFixture]
    public class RandomLogicalQuestions
    {
        [Test]

        public void IsPalindromeTests()
        {
            //Arrange
            var newWord = "Level";
            var Ispalindrome = LogicalLoops.IsPalindrome(newWord);

            //Assert
            Assert.That(Ispalindrome, Is.True);
        }
    }
}
