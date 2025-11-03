namespace LeetCode.ConsoleApp.Challenges.Arrays.FindPivotIndex
{
    public class MySolution
    {
        private int[] _input;

        public MySolution(int[] input)
        {
            _input = input;
        }

        public int Run()
        {
            if (_input.Length == 1)
            {
                return 0;
            }

            var sums = new int[_input.Length];

            for (var i = 0; i < _input.Length; i++)
            {
                if (i == 0)
                {
                    sums[i] = _input[i];
                }
                else
                {
                    sums[i] = sums[i - 1] + _input[i];
                }
            }

            var sumLeft = -1;
            var sumRight = 0;
            int index = 0;
            bool foundPivot = false;
            do
            {
                if (index == _input.Length)
                {
                    break;
                }
                sumLeft = index == 0 ? 0 : sums[index - 1];
                sumRight = sums[_input.Length - 1] - sums[index];

                if (sumLeft == sumRight)
                {
                    foundPivot = true;
                    break;
                }

                index++;
            }
            while (foundPivot == false);
            return foundPivot == true ? index : -1;
        }
    }
}
