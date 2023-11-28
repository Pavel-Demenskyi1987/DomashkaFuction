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
                array[i] = rand.Next(0, 100);
            }

        for (int i = 0; i < 10; i++)
        {
            Console.Write($" {array[i]}"); 
        } 
        Console.WriteLine();

        for (int j = 9; j >=0; j--)
        {
            Console.Write($" {array[j]}"); 
        }
    } 

}

