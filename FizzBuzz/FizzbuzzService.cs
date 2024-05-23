namespace FizzBuzz
{
    public class FizzbuzzService
    {
        public string IsFizzbuzz(int number)
        {
            return number % 3 == 0 ? "Fizz" : number.ToString();
        }
    }
}
