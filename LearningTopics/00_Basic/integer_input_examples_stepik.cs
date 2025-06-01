// Примеры ввода целых чисел в C#,
// написанные в процессе прохождения курса на Stepik.
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class IntegerInputExamplesStepik
{
    public static void Main()
    {
      
        // Пример 1: квадрат числа
        Console.WriteLine("Пример 1: квадрат числа");
        Console.Write("Введите целое число: "); 
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Квадрат числа: {number * number}");

        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: перевод метров в километры
        Console.WriteLine("Пример 2: перевод метров в полные километры");
        Console.Write("Введите количество метров: ");    
        int meters = Convert.ToInt32(Console.ReadLine());
        int kilometers = meters / 1000;
        Console.WriteLine($"Полных километров: {kilometers}");

        Console.WriteLine();

        // Пример 3: 

      
    }
}
