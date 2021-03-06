using NUnit.Framework;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms_DataStruct_Lib.Tests
{
    public class SortingTests
    {
        private readonly ITestOutputHelper _output;

        public SortingTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(Sorting.BubbleSort);
        }

        static int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1 };
            samples[2] = new[] { 2, 1, 3 };
            samples[3] = new[] { 1, 1, 1 };
            samples[4] = new[] { 2, -1, 3, 3 };
            samples[5] = new[] { 4, -5, 3, 3 };
            samples[6] = new[] { 0, -5, 3, 3 };
            samples[7] = new[] { 0, -5, 3, 0 };
            samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }
        void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            _output.WriteLine("---Trace---\n");
            foreach (var el in array)
            {
                _output.WriteLine(el + " ");
            }
            _output.WriteLine("\n---------------------------\n");
        }
    }
}