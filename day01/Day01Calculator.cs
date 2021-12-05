namespace day01
{
    public class Day01Calculator
    {
        public Day01Calculator()
        {
        }

        /*
        * See https://adventofcode.com/2021/day/1 for details of calculation
        */
        public int Calculate(int[] inputNumbers)
        {
            int totalIncreasing = 0;
            int lastNumber = int.MaxValue;
            foreach (int number in inputNumbers)
            {
                if (number > lastNumber)
                {
                    totalIncreasing++;
                }
                lastNumber = number;
            }
            return totalIncreasing;
        }
    }
}