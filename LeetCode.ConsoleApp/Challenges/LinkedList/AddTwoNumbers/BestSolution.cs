namespace LeetCode.ConsoleApp.Challenges.LinkedList.AddTwoNumbers
{
    public class BestSolution
    {
        public ListNode Input1 { get; private set; }
        public ListNode Input2 { get; private set; }

        public BestSolution(ListNode input1, ListNode input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

        public void Run()
        {
            var result = AddTwoNumbers(Input1, Input2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //TODO: refatorar a solução usando o carry "vai um"

            return null;
        }
    }
}
