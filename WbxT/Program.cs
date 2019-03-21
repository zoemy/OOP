using System;
using WbxTraining.Loop;

namespace WbxT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Loops!");
            WhileHelper.PrintNumbers();
            WhileHelper.PrintNumbers(7, 12);
            WhileHelper.SumNumbersOnArray();  
            Console.ReadLine();
        }
    }
}
