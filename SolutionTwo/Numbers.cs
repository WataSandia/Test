namespace SolutionTwo
{
    public class Numbers
    {
        public readonly List<int> numbers;

        public Numbers()
        {
            numbers = Enumerable.Range(1, 100)
                .ToList();
        }

        public bool Extract(int number)
        {
            if (numbers.Count < 100)
                throw new InvalidOperationException("This method was called already.");

            if (number < 1)
                throw new ArgumentOutOfRangeException(nameof(number), number, "Input can't be less than 1.");         

            else if (number > 100)
                throw new ArgumentOutOfRangeException(nameof(number), number, "Input can't be greater than 100.");

            var isRemoved = numbers.Remove(number);
            return isRemoved;
        }

        public int Calculate()
        {
            if (numbers.Count is 100)
                throw new InvalidOperationException($"{Extract} method must be called first.");

            const int EXPECTED_SUM = 5050;
            int realSum = numbers.Sum();

            int missingNumber = EXPECTED_SUM - realSum;
            return missingNumber;
        }
    }
}
