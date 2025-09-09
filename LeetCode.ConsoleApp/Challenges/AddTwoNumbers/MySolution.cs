using System.Numerics;

namespace LeetCode.ConsoleApp.Challenges.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        public class MySolution
        {
            public static void Run()
            {
                //[1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1]

                var l1 = new ListNode(1,
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

                var l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
                var result = AddTwoNumbers(l1, l2);
            }

            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
            }

            public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                var v1 = GetNumber(l1);
                var v2 = GetNumber(l2);

                var sum = v1 + v2;
                ListNode result = CreateListNode(sum);

                return result;
            }

            private static BigInteger GetNumber(ListNode root)
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

            private static ListNode CreateListNode(BigInteger number)
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

            private static ListNode GetLastFilled(ListNode root)
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
}