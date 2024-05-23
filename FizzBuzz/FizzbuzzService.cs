namespace FizzBuzz
{
    public class FizzbuzzService
    {
        public string IsFizzbuzz(int number)
        {
            return number % 15 == 0 ? "Fizzbuzz" :
                   number % 3 == 0 ? "Fizz" : 
                   number % 5 == 0 ? "Buzz" :                    
                   number.ToString();
        }
    }
}
