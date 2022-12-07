using Concepts_and_Interview_Questions.Basic.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts_and_Interview_Questions_TestProject.Basic
{
    [TestClass]
    public class RunningSum1DArrayTest : RunningSum1DArray
    {
        [TestMethod]
        public void BasicTest()
        {
            var test1 = new int[] { 1, 2, 3, 4 };
            var expectedOutput1= new int[] { 1, 3, 6, 10 };

            var actualOutput1 = RunningSum(test1);
            Assert.AreEqual(expectedOutput1[0], actualOutput1[0]);
            Assert.AreEqual(expectedOutput1[1], actualOutput1[1]);
            Assert.AreEqual(expectedOutput1[2], actualOutput1[2]);
            Assert.AreEqual(expectedOutput1[3], actualOutput1[3]);
        }
    }
}
