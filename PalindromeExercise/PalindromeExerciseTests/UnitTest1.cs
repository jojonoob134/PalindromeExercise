using System;
using System.ComponentModel;
using System.Numerics;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("race car", "racecar")]
        [InlineData("a man a plan a canal panama", "amanaplanacanalpanama")]
        [InlineData("level", "level")]
        [InlineData("madam", "madam")]
        [InlineData("was it a car or a cat i saw", "wasitacaroracatisaw")]
        public void Test1(string input, string expected)
        {
            //throw new NotImplementedException();
            var isSame = new Methods();

            var sameIs = isSame.reversed(input);

            Assert.Equal(sameIs, expected);
        }
    }
}
