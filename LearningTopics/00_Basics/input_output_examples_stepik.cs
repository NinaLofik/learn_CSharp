// Примеры ввода и вывода данных в C#,
// написанные в процессе прохождения курса на Stepik.
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class InputOutputExamplesStepik
{
    public static void Main()
    {
      
        // Пример 1: приветсвие (ввод строки с клвиатуры и вывод сообщения)
        Console.WriteLine("Пример 1: приветствие пользователя");
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine(); // пустая строка для отделения вывода
        Console.WriteLine($"Привет, {name}");

        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: лучшая книга (ввод строки с клвиатуры и вывод сообщения)
        Console.WriteLine("Пример 2: лучшая книга");
        Console.Write("Введите название книги: ");    
        string book = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{book} - лучшая книга!");

        Console.WriteLine();

        // Пример 3: повторение строк (ввод трех строк с клавиатуры и вывод сообщения)
        Console.WriteLine("Пример 3: Повторяшка");
        Console.WriteLine("Введите три строки: ");
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{first}\n{second}\n{third}");

        Console.WriteLine();

        // Пример 4: обратный порядок (ввод трех строк с клавиатуры и вывод сообщения)
        Console.WriteLine("Пример 4: обратный порядок");
        Console.WriteLine("Введите три строки: ");
        string firstA = Console.ReadLine();
        string secondA = Console.ReadLine(); 
        string thirdA = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{thirdA}\n{secondA}\n{firstA}");

        Console.WriteLine();
        
        // Пример 5: пользовательский разделитель (ввод четырех строк с клавиатуры и вывод сообщения)
        Console.WriteLine("Пример 5: пользовательский разделитель");
        Console.WriteLine("Введите четыре строки (первая - разделитель и три строки): ");
        string separator = Console.ReadLine();
        string firstB = Console.ReadLine();
        string secondB = Console.ReadLine();
        string thirdB = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{firstB}{separator}{secondB}{separator}{thirdB}");
    }
}
