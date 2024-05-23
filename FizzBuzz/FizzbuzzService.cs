namespace FizzBuzz
{
    public class FizzbuzzService
    {
        public void ProcessFizzbuzz(object start, object end)
        {
            if (IsString(start) || IsString(end))
            {
                Console.WriteLine("Invalid input: inputs should be integers.");
                return;
            }

            int startNumber = Convert.ToInt32(start);
            int endNumber = Convert.ToInt32(end);

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(GetFizzbuzzOutput(i));
            }
        } 

        private bool IsString(object input) 
        {
            return input.GetType() == typeof(string);
        }

        private string GetFizzbuzzOutput(int number)
        {
            return number % 15 == 0 ? "Fizzbuzz" :
                   number % 3 == 0 ? "Fizz" : 
                   number % 5 == 0 ? "Buzz" :                    
                   number.ToString();
        }
    }
}
