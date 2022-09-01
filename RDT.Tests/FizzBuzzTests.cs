namespace RDT.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private static FizzBuzz _fizzBuzz = null!;

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            _fizzBuzz = new FizzBuzz();
        }


        [DataTestMethod]
        [DynamicData(nameof(NumericalData), DynamicDataSourceType.Method)]
        public void GetFizzBuzz_Returns_Number(int number, string? expected)
        {
            var result = _fizzBuzz.GetFizzBuzz(number);
            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DynamicData(nameof(FizzData), DynamicDataSourceType.Method)]
        public void GetFizzBuzz_Returns_Fizz(int number, string? expected)
        {
            var result = _fizzBuzz.GetFizzBuzz(number);
            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DynamicData(nameof(BuzzData), DynamicDataSourceType.Method)]
        public void GetFizzBuzz_Returns_Buzz(int number, string? expected)
        {
            var result = _fizzBuzz.GetFizzBuzz(number);
            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DynamicData(nameof(FizzBuzzData), DynamicDataSourceType.Method)]
        public void GetFizzBuzz_Returns_FizzBuzz(int number, string? expected)
        {
            var result = _fizzBuzz.GetFizzBuzz(number);
            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DynamicData(nameof(OutOfRangeDataData), DynamicDataSourceType.Method)]
        public void GetFizzBuzz_Returns_Null_For_Out_Of_Range_Numbers(int number)
        {
            var result = _fizzBuzz.GetFizzBuzz(number);
            Assert.IsNull(result);
        }

        public static IEnumerable<object[]> NumericalData()
        {
            yield return new object[] { 1, "1" };
            yield return new object[] { 2, "2" };
            yield return new object[] { 4, "4" };
            yield return new object[] { 7, "7" };
            yield return new object[] { 14, "14" };
            yield return new object[] { 16, "16" };
        }

        public static IEnumerable<object[]> FizzData()
        {
            yield return new object[] { 3, "Fizz" };
            yield return new object[] { 6, "Fizz" };
            yield return new object[] { 99, "Fizz" };
        }

        public static IEnumerable<object[]> BuzzData()
        {
            yield return new object[] { 5, "Buzz" };
            yield return new object[] { 10, "Buzz" };
            yield return new object[] { 100, "Buzz" };
        }

        public static IEnumerable<object[]> FizzBuzzData()
        {
            yield return new object[] { 15, "FizzBuzz" };
            yield return new object[] { 90, "FizzBuzz" };
        }

        public static IEnumerable<object[]> OutOfRangeDataData()
        {
            yield return new object[] { 0 };
            yield return new object[] { 101 };
            yield return new object[] { 102 };
            yield return new object[] { 105 };
        }
    }
}