﻿using System.Collections.Generic;
using Should;
using Xunit;

namespace Kata.Chop.Tests
{
    public class ChopTests
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void LinqChop_FindIntInArray(int intToFind, int[] arrayOfInts, int expectedPosition)
        {
            var position = new LinqChop().Find(intToFind, arrayOfInts);

            position.ShouldEqual(expectedPosition);
        }
    }

    public class TestData : TheoryData<int, int[], int>
    {
        public TestData()
        {
            Add(1, new List<int>{1,2,3,4}.ToArray(), 0);
            Add(0, new[] {1, 2, 3, 4}, -1);
            Add(3, new []{1,2,3,4}, 2);
            Add(1, new []{2,4,6,8,10,1}, 5);
        }
    }
}