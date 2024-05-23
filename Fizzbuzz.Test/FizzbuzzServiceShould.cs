using FizzBuzz;

namespace Fizzbuzz.Test
{
    public class FizzbuzzServiceShould
    {
        private readonly FizzbuzzService _sut = new FizzbuzzService();

        [Fact]
        public void FizzbuzzService_should_return_fizz()
        {
            var expected = "Fizz";
            var actual = _sut.IsFizzbuzz(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzbuzzService_IsNotDivisibleBy3_should_return_number()
        {
            var expected = "1";
            var actual = _sut.IsFizzbuzz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzbuzzService_should_return_buzz()
        {
            var expected = "Buzz";
            var actual = _sut.IsFizzbuzz(5);
            Assert.Equal(expected, actual);
        }
    }
}
