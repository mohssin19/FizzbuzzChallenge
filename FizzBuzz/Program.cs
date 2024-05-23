namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzzService = new FizzbuzzService();
            fizzbuzzService.ProcessFizzbuzz(1, 100);
        }
    }
}
