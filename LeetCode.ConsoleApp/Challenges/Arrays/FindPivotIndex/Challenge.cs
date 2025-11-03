using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.Arrays.FindPivotIndex
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
            var inputs = new List<int[]>()
            {
                new int[] {1,7,3,6,5,6}, // Expected output: 3
                new int[] {1,2,3},       // Expected output: -1
                new int[] {2,1,-1},     // Expected output: 0
                new int[] {0,0,0,0,0},   // Expected output: 0
            };

            foreach (var input in inputs)
            {
                var solution = new MySolution(input);
                var result = solution.Run();

                Console.WriteLine($"Input: [{string.Join(", ", input)}] => Pivot Index: {result}");
            }
        }

        [Benchmark]
        public void RunBest()
        {
            var solution = new BestSolution();
            solution.Run();
        }
    }
}
