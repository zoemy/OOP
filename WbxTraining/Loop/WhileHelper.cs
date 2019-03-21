using System;

namespace WbxTraining.Loop
{
    public static class WhileHelper
    {

        public static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers from 10 to 20");
            /* local variable definition */
            int number = 10;

            /* while loop execution */
            while (number < 20)
            {
                Console.WriteLine("Number: {0}", number);
                number++;
            }
        }

        public static void PrintNumbers(int initial, int maximun)
        {
            Console.WriteLine($"Print numbers From {initial} to {maximun}");
            while (initial < maximun)
            {
                Console.WriteLine($"Number: {initial}");
                initial++;
            }
        }


        public static int SumNumbersOnArray()
        {
            Console.WriteLine("Sum the following numbers");
            int[] numbers = new int[] { 6, 7, 8, 10 };

            int sum = 0;
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine($"Number: {numbers[i]}");
                sum += numbers[i];
                i++;
            }
            Console.WriteLine($"Sum = {sum}");
            return sum;
        }

        public static void PrintSkiping()
        {
            Console.WriteLine("Print Skiping");
            int number = 10; 
            while (number < 20)
            {
                Console.WriteLine("Number: {0}", number);
                number++; 
                if (number > 15)
                { 
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}
