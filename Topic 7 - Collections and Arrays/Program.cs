namespace Topic_7___Collections_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] numbers = new int[30];

            int evenNumberAmount = 0;

            for (int i = 1; i <= 30; i++)
            {
                numbers[i - 1] = generator.Next(1, 101);
                Console.Write(numbers[i - 1] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i <= numbers.Length; i++)
            {
                if ((numbers[i - 1] % 2) == 0)
                    evenNumberAmount++;
            }

            Console.WriteLine();

            Console.WriteLine("There are " + evenNumberAmount + " even numbers in the array!");

            Console.WriteLine();

            for (int i = 1; i <= numbers.Length; i++)
            {
                if ((numbers[i - 1] % 5) == 0)
                    Console.Write(numbers[i - 1] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= numbers.Length; i++)
            {
                if ((i % 2) != 0)
                    Console.Write(numbers[i - 1] + " ");
            }
        }
    }
}
