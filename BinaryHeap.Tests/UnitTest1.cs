using Xunit;
using BinaryHeap;

namespace BinaryHeap.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MinHeap<int> heap = new MinHeap<int>();
            for (var i = 10; i > 0; i--)
                heap.Add(i);

            for (var i = 1; i <= 10; i++)
            {
                Assert.Equal(heap.peekMin(), i);
                Assert.Equal(heap.popMin(), i);

            }

        }
    }
}
