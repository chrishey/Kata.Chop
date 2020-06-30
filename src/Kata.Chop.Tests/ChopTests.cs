using System.Collections.Generic;
using Should;
using Xunit;

namespace Kata.Chop.Tests
{
    public class ChopTests
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void FindIntInArray(int intToFind, int[] arrayOfInts, int expectedPosition)
        {
            var position = new Chop().Find(intToFind, arrayOfInts);

            position.ShouldEqual(expectedPosition);
        }
    }

    public class TestData : TheoryData<int, int[], int>
    {
        public TestData()
        {
            Add(1, new List<int>{1,2,3,4}.ToArray(), 0);
        }
    }
}