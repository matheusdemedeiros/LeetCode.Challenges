using System.Numerics;

namespace LeetCode.ConsoleApp.Challenges.LinkedList.AddTwoNumbers
{
    public class MySolution
    {
        public ListNode Input1 { get; set; }
        public ListNode Input2 { get; set; }

        public MySolution(ListNode input1, ListNode input2)
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
            var v1 = GetNumber(l1);
            var v2 = GetNumber(l2);

            var sum = v1 + v2;
            ListNode result = CreateListNode(sum);

            return result;
        }

        private BigInteger GetNumber(ListNode root)
        {
            if (root == null)
            {
                return 0;
            }

            string numberText = string.Empty;
            ListNode curr = root;

            while (curr != null)
            {
                numberText += $"{curr.val}";
                curr = curr.next;
            }

            if (numberText == string.Empty)
            {
                return 0;
            }

            string reverseText = new string(numberText.Reverse().ToArray());

            BigInteger number = BigInteger.Parse(reverseText);

            return number;
        }

        private ListNode CreateListNode(BigInteger number)
        {
            string numberText = $"{number}";
            string reverseText = new string(numberText.Reverse().ToArray());

            int i = 0;
            ListNode result = null;
            ListNode currNode = null;
            ListNode last = null;

            while (i < reverseText.Length)
            {
                var str = reverseText[i].ToString();

                int curr = int.Parse(str);

                if (result == null)
                {
                    result = new ListNode(curr, null);
                    last = GetLastFilled(result);
                }
                else
                {
                    last = GetLastFilled(result);
                    currNode = new ListNode(curr, null);
                    last.next = currNode;
                }
                i++;
            }

            return result;
        }

        private ListNode GetLastFilled(ListNode root)
        {
            ListNode last = root;
            while (root != null)
            {
                last = root;
                root = root.next;
            }

            return last;
        }
    }
}
