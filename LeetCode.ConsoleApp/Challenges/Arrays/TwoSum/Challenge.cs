using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.Arrays.TwoSum
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public List<(int[] nums, int target)> Inputs { get; set; }

        public Challenge()
        {
            Inputs = new List<(int[] nums, int target)>
            {
                (new int[] {2,7,11,15}, 9),
                (new int[] {3,2,4}, 6),
                (new int[] {3,3}, 6),
                (new int[] {1,2,3,4,5,6,7,8,9,10}, 19),
                (new int[] {1,2,3,4,5,6,7,8,9,10}, 20)
            };
        }

        [Benchmark]
        public void RunMy()
        {
            foreach (var (nums, target) in Inputs)
            {
                var solution = new MySolution(nums, target);
                solution.Run();
            }
        }

        [Benchmark]
        public void RunBest()
        {
            foreach (var (nums, target) in Inputs)
            {
                var solution = new BestSolution(nums, target);
                solution.Run();
            }
        }
    }
}
