using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break; 
            }

            if (int.TryParse(input, out int number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break; 
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введено не целое число. Попробуйте ещё раз.");
            }
        }

        Console.ReadLine();
    }

    static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;
        num = Math.Abs(num); 

        while (num > 0)
        {
            sum += num % 10; 
            num /= 10; 
        }

        return sum % 2 == 0;
    }
}

