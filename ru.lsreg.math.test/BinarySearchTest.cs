using System;
using Xunit;
using ru.lsreg.math;

namespace ru.lsreg.math.test
{
    public class BinarySearchTest
    {
        [Fact]
        public void TestBinarySearch()
        {
            var data = new int[] { 2, 4, 6, 8, 10 };
            Assert.Equal(BinarySearch.Search(data, 2), 0);
            Assert.Equal(BinarySearch.Search(data, 4), 1);
            Assert.Equal(BinarySearch.Search(data, 6), 2);
            Assert.Equal(BinarySearch.Search(data, 8), 3);
            Assert.Equal(BinarySearch.Search(data, 10), 4);
            Assert.Equal(BinarySearch.Search(data, 11), -1);
            Assert.Equal(BinarySearch.Search(data, -1), -1);
        }
    }
}