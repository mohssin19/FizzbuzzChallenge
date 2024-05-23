using FizzBuzz;

namespace Fizzbuzz.Test
{
    public class FizzbuzzServiceShould
    {
        private readonly FizzbuzzService _sut = new FizzbuzzService();

        //[Fact]
        //public void FizzbuzzService_should_return_fizz()
        //{
        //    var expected = "Fizz";
        //    var actual = _sut.GetFizzbuzzOutput(3);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void FizzbuzzService_IsNotDivisibleBy3_should_return_number()
        //{
        //    var expected = "1";
        //    var actual = _sut.GetFizzbuzzOutput(1);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void FizzbuzzService_should_return_buzz()
        //{
        //    var expected = "Buzz";
        //    var actual = _sut.GetFizzbuzzOutput(5);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void FizzbuzzService_IsNotDivisibleBy5_should_return_number()
        //{
        //    var expected = "11";
        //    var actual = _sut.GetFizzbuzzOutput(11);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void FizzbuzzService_should_return_Fizzbuzz()
        //{
        //    var expected = "Fizzbuzz";
        //    var actual = _sut.GetFizzbuzzOutput(15);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void FizzbuzzService_IsNotDivisibleBy3or5_return_number()
        //{
        //    var expected = "29";
        //    var actual = _sut.GetFizzbuzzOutput(29);
        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void FizzBuzzProcessor_ShouldPrintCorrectOutput()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _sut.ProcessFizzbuzz(1, 15);
                var expected = string.Join(Environment.NewLine, new[]
                {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizzbuzz"
            }) + Environment.NewLine;
                Assert.Equal(expected, sw.ToString());
            }
        }

        [Fact]
        public void FizzBuzzProcessor_ShouldLogMessage_ForStringInput()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _sut.ProcessFizzbuzz("1", 100);
                Assert.Contains("Invalid input:", sw.ToString());
            }
        }
    }
}
