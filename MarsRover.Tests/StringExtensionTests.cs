using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class StringExtensionTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ConvertToCharList_ShouldConvertStringInputIntoCharList(string input, List<char> expected)
        {
            var actual = input.ConvertToCharList();

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { "f,b,l,r", new List<char>{'f','b','l','r'}},
                new object[] { "f b l r", new List<char>{'f','b','l','r'}},
                new object[] { "fblr", new List<char>{'f','b','l','r'}},
            };    
    }
}