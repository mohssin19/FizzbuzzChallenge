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
    }
}
