using System; 

namespace WbxTraining.Loop
{
    public static class DoWhileHelper
    {
        public static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers from 10 to 20");
            /* local variable definition */
            int number = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("Number: {0}", number);
                number = number ++;
            }
            while (number < 20); 
        }

        public static void PrintNumbers(int initial, int maximun)
        {
            Console.WriteLine($"Print numbers From {initial} to {maximun}");
            do
            {
                Console.WriteLine($"Number: {initial}");
                initial++;
            } while (initial < maximun);
        }

        public static int SumNumbersOnArray()
        {
            Console.WriteLine("Sum the following numbers");
            int[] numbers = new int[] { 6, 7, 8, 10 };

            int sum = 0;
            int i = 0;
            do
            {
                Console.WriteLine($"Number: {numbers[i]}");
                sum += numbers[i];
                i++;
            } while (i < numbers.Length);
            Console.WriteLine($"Sum = {sum}");
            return sum;
        }
    }
}
