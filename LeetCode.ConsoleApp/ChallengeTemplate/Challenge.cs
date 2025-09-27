using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.CategoryName.ChallengeName
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public Challenge()
        {
        }

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
