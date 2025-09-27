namespace LeetCode.ConsoleApp.Challenges.Arrays.TwoSum
{
    public class MySolution
    {
        public int[] Input { get; set; }
        public int Target { get; }

        public MySolution(int[] input, int target)
        {
            Input = input;
            Target = target;
        }

        public int[] Run()
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < Input.Length; i++)
            {
                int complement = Target - Input[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(Input[i]))
                {
                    map[Input[i]] = i;
                }
            }

            return Array.Empty<int>();
        }
    }
}
