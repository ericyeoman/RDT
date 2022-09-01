namespace RDT
{
    public class FizzBuzz
    {
        public void Run()
        {
            Enumerable.Range(1, 100)
                .Select(GetFizzBuzz)
                .ToList()
                .ForEach(Console.WriteLine);
        }

        public string? GetFizzBuzz(int number)
        {
            if (number < 1 || number > 100)
                return null;

            var result = string.Empty;

            if (number % 3 == 0)
                result = "Fizz";
            if (number % 5 == 0)
                result += "Buzz";

            return result.Equals(string.Empty) ? number.ToString() : result;

        }

    }
}
