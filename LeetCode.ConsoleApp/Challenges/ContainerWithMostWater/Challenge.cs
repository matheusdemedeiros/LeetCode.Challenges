using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.ContainerWithMostWater
{
    [MemoryDiagnoser]
    public class Challenge
    {
        [Benchmark]
        public void RunMy()
        {
            var solution = new MySolution();
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
}
