using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace PseudoEnumerable.Tests
{
    public class EnumerableExtensionTests
    {
        [Test]
        public void Order_Test()
        {
            string[] array = { "gds", "ddd", "ccc", "bbb", "aaaaaaaa", "aaa" };
            string[] expected = { "aaa", "aaaaaaaa", "bbb", "ccc", "ddd", "gds" };
            CollectionAssert.AreEqual(expected, array.OrderAccordingTo(Comparer<string>.Default));
        }

        [Test]
        public void Order_Test_Delegate()
        {
            string[] array = { "gds", "ddd", "ccc", "bbb", "aaaaaaaa", "aaa" };
            string[] expected = { "aaa", "aaaaaaaa", "bbb", "ccc", "ddd", "gds" };
            CollectionAssert.AreEqual(expected, array.OrderAccordingTo((x,y)=>x.CompareTo(y)));
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 2 })]
        [TestCase(new[] { 2, 4, 6 }, new[] { 2, 4, 6 })]
        [TestCase(new[] { 1, 3, 5 }, new int[0])]
        public void OddTest(int[] array, int[] res)
        {
            CollectionAssert.AreEqual(res, array.Filter(new OddPredicate()));
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 2 })]
        [TestCase(new[] { 2, 4, 6 }, new[] { 2, 4, 6 })]
        [TestCase(new[] { 1, 3, 5 }, new int[0])]
        public void OddTest_Delegate(int[] array, int[] res)
        {
            CollectionAssert.AreEqual(res, array.Filter((x) => x % 2 == 0));
        }

        [TestCase(new[] { 1, 2, 3 },ExpectedResult = new[] { "1","2","3" })]
        public string[] Transform_To_String_Deegate(int[] array)
        {
            return  array.Transform<int, string>((x) => x.ToString()).ToArray();
        }

        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = new[] { "1", "2", "3" })]
        public string[] Transform_To_String(int[] array)
        {
            return array.Transform<int, string>(new ToStringTransformer()).ToArray();
        }
    }
}