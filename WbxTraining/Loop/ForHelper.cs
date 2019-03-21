using System; 

namespace WbxTraining.Loop
{
    public static class ForHelper
    {
        public static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers from 10 to 20");
            /* for loop execution */
            for (int number = 10; number < 20; number++)
            {
                Console.WriteLine("Number: {0}", number);
            }
        }

        public static void PrintNumbers(int initial, int maximun)
        {
            Console.WriteLine($"Print numbers From {initial} to {maximun}");
            for (int number = initial; number < 20; number++)
            {
                Console.WriteLine($"Number: {number}");
                initial++;
            }
        }

        public static int SumNumbersOnArray()
        {
            Console.WriteLine("Sum the following numbers");
            int[] numbers = new int[] { 6, 7, 8, 10 };

            int sum = 0; 
            for (int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number: {numbers[i]}");
                sum += numbers[i];
                i++;
            }
            Console.WriteLine($"Sum = {sum}");
            return sum;
        }
    }
}
