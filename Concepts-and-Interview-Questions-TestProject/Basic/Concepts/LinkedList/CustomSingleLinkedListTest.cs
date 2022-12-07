using Concepts_and_Interview_Questions.Basic.Concepts;

namespace Concepts_and_Interview_Questions_TestProject.Basic.Concepts.LinkedList
{
    [TestClass]
    public class CustomSingleLinkedListTest
    {
        [TestMethod]
        public void BasicSingleLinkedListTest()
        {
            var csl = new CustomSingleLinkedList();

            csl.Add("helloo");
            csl.Add("helloo1");
            csl.Add("helloo2");
            csl.Add("helloo3");
            csl.Add("helloo4");

            csl.Add("hellooIntermediate", 3);

            var abc = csl.DisplayNodesData();

            csl.Delete(2);

            var dfdd = csl.DisplayNodesData();

            Console.ReadLine();

        }
    }
}
