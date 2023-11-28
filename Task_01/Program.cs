using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            // Проверяем, является ли ввод символом 'q'
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break; // Выход из бесконечного цикла
            }

            // Пытаемся преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверяем, является ли сумма цифр числа чётной
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break; // Выход из бесконечного цикла
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

    // Функция для проверки, является ли сумма цифр числа чётной
    static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;
        num = Math.Abs(num); // Берем модуль числа, чтобы избежать проблем с отрицательными числами

        while (num > 0)
        {
            sum += num % 10; // Добавляем последнюю цифру к сумме
            num /= 10; // Убираем последнюю цифру из числа
        }

        return sum % 2 == 0; // Возвращаем true, если сумма чётная
    }
}

