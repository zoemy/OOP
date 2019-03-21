using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WbxTraining.Loop
{
    // Cannot use foreach on tuple.
    public static class ForEachHelper
    {
        public static void PrintArray()
        {
            Console.WriteLine("Print Array");

            string[] pets = { "dog", "cat", "bird" };


            // ... Loop with the foreach keyword.
             
            foreach (string pet in pets)
            {
                Console.WriteLine("FOREACH ITEM: " + pet);
            }  
        }

        public static bool Exists()
        {
            string[] pets = { "dog", "cat", "bird" };
              
            foreach (string pet in pets)
            {
                if (pet == "dog")
                {
                    return true;
                }
            }
            return false;
        }

        public static void PrintList()
        {
            Console.WriteLine("Print List");
            List<string> pets = new List<string> { "dog", "cat", "bird" }; 
  
            foreach (string pet in pets)
            {
                Console.WriteLine("FOREACH ITEM: " + pet);
            }
        }

        public static void PrintReverse()
        {
            Console.WriteLine("Print List");
            string[] pets = { "bird", "frog",  "dog", "snake"};

            foreach (string pet in pets.Reverse())
            {
                Console.WriteLine("FOREACH ITEM: " + pet);
            }
        }

        /// <summary>
        /// We then try calling the Remove method. This fails because of a restriction of the foreach-loop.
        /// If you want to add or remove elements during a loop, consider a for-loop. But be careful to maintain correct indexes.
        /// </summary>
        public static void TryToRemove()
        {
            Console.WriteLine("Try To Remove");
            List<string> pets = new List<string> { "dog", "cat", "bird" };
            try
            {
                foreach (string pet in pets)
                {
                    pets.Remove(pet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
