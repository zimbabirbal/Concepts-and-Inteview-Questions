using Concepts_and_Interview_Questions.Intermediate.Problems;

namespace Concepts_and_Interview_Questions_TestProject.Intermediate
{
    [TestClass]
    public class SetMismatchTest : SetMismatch
    {
        [TestMethod]
        public void BasicTest()
        {
            var test1 = new int[] { 1, 2, 2 };
            var expectedTest1Output = new int[] { 2, 3 };

            var actualOutput = FindErrorNums(test1);

            Assert.AreEqual(expectedTest1Output[0], actualOutput[0], "Duplicate Value must be 2" );
            Assert.AreEqual(expectedTest1Output[1], actualOutput[1], "Repalce Value must be 3");


            var test2 = new int[] { 1, 1,};
            var expectedTest2Output = new int[] { 1, 2 };

            var actualOutput2 = FindErrorNums(test2);

            Assert.AreEqual(expectedTest2Output[0], actualOutput2[0], "Duplicate Value must be 1");
            Assert.AreEqual(expectedTest2Output[1], actualOutput2[1], "Repalce Value must be 2");


            var test3 = new int[] { 2, 2 };
            var expectedTest3Output = new int[] { 2, 1 };

            var actualOutput3 = FindErrorNums(test3);

            Assert.AreEqual(expectedTest3Output[0], actualOutput3[0], "Duplicate Value must be 2");
            Assert.AreEqual(expectedTest3Output[1], actualOutput3[1], "Repalce Value must be 1");



            var test4 = new int[] { 1, 2, 3,3, 4 };
            var expectedTest4Output = new int[] { 3,5 };

            var actualOutput4 = FindErrorNums(test4);

            Assert.AreEqual(expectedTest4Output[0], actualOutput4[0], "Duplicate Value must be 3");
            Assert.AreEqual(expectedTest4Output[1], actualOutput4[1], "Repalce Value must be 5");


            var test5 = new int[] { 37, 62, 43, 27, 12, 66, 36, 18, 39, 54, 61, 65, 47, 32, 23, 2, 46, 8, 4, 24, 29, 38, 63, 39, 25, 11, 45, 28, 44, 52, 15, 30, 21, 7, 57, 49, 1, 59, 58, 14, 9, 40, 3, 42, 56, 31, 20, 41, 22, 50, 13, 33, 6, 10, 16, 64, 53, 51, 19, 17, 48, 26, 34, 60, 35, 5 };
            var expectedTest5Output = new int[] { 39, 55 };

            var actualOutput5 = FindErrorNums(test5);

            Assert.AreEqual(expectedTest5Output[0], actualOutput5[0], "Duplicate Value must be 39");
            Assert.AreEqual(expectedTest5Output[1], actualOutput5[1], "Repalce Value must be 55");

        }
    }
}
