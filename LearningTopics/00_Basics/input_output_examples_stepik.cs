// Примеры ввода и вывода данных в C#,
// написанные в процессе прохождения курса на Stepik.
// Все примеры находятся в одном методе Main,
// поэтому их можно проверить за один запуск.

using System;

public class InputOutputExamplesStepik
{
    public static void Main()
    {
      
        // Пример 1: приветсвие (ввод строки с клвиатуры и вывод сообщения)
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}");

        // Пример 2: лучшая книга (ввод строки с клвиатуры и вывод сообщения)
        Console.Write("Введите название книги: ");    
        string book = Console.ReadLine();             
        Console.WriteLine($"{book} - лучшая книга!");

        // Пример 3: повторение строк
        Console.WriteLine("Введите три строки: ");
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();
        Console.WriteLine($"{first}\n{second}\n{third}");

        // Пример 4: обратный порядок
        Console.WriteLine("Введите три строки: ");
        string firstA = Console.ReadLine();
        string secondA = Console.ReadLine(); 
        string thirdA = Console.ReadLine();
        Console.WriteLine($"{thirdA}\n{secondA}\n{firstA}");
      
        // Пример 5: пользовательский разделитель
        Console.WriteLine("Введите четыре строки (первая - разделитель и три строки): ");
        string separator = Console.ReadLine();
        string firstB = Console.ReadLine();
        string secondB = Console.ReadLine();
        string thirdB = Console.ReadLine();
        Console.WriteLine($"{firstB}{separator}{secondB}{separator}{thirdB}");
    }
}
