using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.AddTwoNumbers
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public ListNode Input1 { get; private set; }
        public ListNode Input2 { get; private set; }

        public Challenge()
        {
            Input2 = new ListNode(1,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(0,
            new ListNode(1)))))))))))))))))))))))))))));

            Input2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
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
            var solution = new BestSolution(Input1, Input2);
            solution.Run();
        }
    }
}
