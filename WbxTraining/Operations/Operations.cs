using System; 

namespace WbxTraining.Operations
{
    public class Operations
    {
        int[] numbers = { 10, 15, 12, 0, 0 };
        const int capacity = 5;     
        int count = 3; 
          
        public void PrintArray()
        {
            for (int i = 0; i < count; i++)
            { 
                Console.Write("{0} ", numbers[i]);
            }
        }

        public int Find(int numberToSearch)
        {
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                    Console.WriteLine($"{numberToSearch} encontrado en la posición {0}.");
                    return i;
                }
            } 
            return -1;    
        }

        public int FindMaxNumber()
        {
            int maximo = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] > maximo)
                {
                    maximo = numbers[i];
                } 
            } 
            Console.WriteLine("El máximo es {0} ", maximo);
            return maximo;
        }

        public void Add(int numberToAdd)
        {
            Console.WriteLine($"Añadiendo {numberToAdd} al final");
            if (count < capacity)
            {
                numbers[count] = numberToAdd;
                count++;
            }
            PrintArray();
        }

        public void Delete(int index)
        {
            Console.WriteLine("Borrando el dato en la posición", index); 
            for (int i = index; i < count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }   
            count--;
            PrintArray();
        }

        public void Insert(int index, int number)
        {
            if (count < capacity)
            {
                Console.WriteLine($"Insertando {number} en la posición {index}"); 
                for (int i = count; i > index; i--)
                {
                    numbers[i] = numbers[i - 1];
                } 
                numbers[index] = number;
                count++;
            }
            PrintArray();
        }
    }
}
