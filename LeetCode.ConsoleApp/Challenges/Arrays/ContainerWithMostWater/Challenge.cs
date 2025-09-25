using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.Arrays.ContainerWithMostWater
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public int[] Input { get; set; }

        public Challenge()
        {
            Input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        }

        [Benchmark]
        public void RunMy()
        {
            var solution = new MySolution(Input);
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
