using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int[] array = new int[10];
        Random rand = new();
        for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(99, 1000);

                if( array[i]%2 == 0)
                {
                    count++;
                }


            }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]); 
        }   
        Console.WriteLine($"Количество четных чисел в массиве {count}");   

    }
}
