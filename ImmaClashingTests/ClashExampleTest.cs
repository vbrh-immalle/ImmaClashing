using System;
using Xunit;
using ImmaClashing;

namespace ImmaClashingTests
{
    public class ClashExampleTest
    {
        [Fact]
        public void Test1()
        {
            string inputFile = "Clashes/ClashExample_input1.txt";
            string outputFile = "Clashes/ClashExample_output1.txt";
            var clash = new ClashExample(inputFile);
            var expected = System.IO.File.ReadAllText(outputFile);

            Assert.Equal(expected, clash.GetOutput().Trim());
        }
    }
}
