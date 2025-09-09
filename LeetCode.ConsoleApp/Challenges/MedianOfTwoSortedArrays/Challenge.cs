using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.MedianOfTwoSortedArrays
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public int[] Input1 { get; set; }
        public int[] Input2 { get; set; }

        public Challenge()
        {
            Input1 = new int[] { 1, 3,2 };
            Input2 = new int[] { 2 };
        }

        [Benchmark]
        public void RunMy()
        {
            var solution = new MySolution(Input1, Input2);
            solution.Run();
        }

        [Benchmark]
        public void RunBest()
        {
            var solution = new BestSolution();
            solution.Run();
        }
    }
}
