using System;
using Xunit;

namespace _99BottlesOfOOP
{
    public class CapitalizationTests
    {
        [Theory]
        [InlineData("","")]
        [InlineData(null,null)]
        [InlineData("A","A")]
        [InlineData("a","A")]
        [InlineData("ab","Ab")]
        public void CapitalizesCorrectly(string input, string expected)
        {
            Assert.Equal(expected, input.Capitalize());
        }        
    }
}