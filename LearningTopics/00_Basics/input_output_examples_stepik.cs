// Примеры ввода и вывода данных на C#,
// написанные в процессе прохождения курса (Stepik).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class InputOutputExamplesStepik
{
    public static void Main()
    {
      
        // Пример 1: приветсвие (ввод строки с клвиатуры и вывод сообщения)
        Console.WriteLine("Пример 1: приветствие пользователя");
        Console.Write("Введите ваше имя и нажмите Enter: ");
        string name = Console.ReadLine();
        Console.WriteLine(); // пустая строка для отделения вывода
        Console.WriteLine($"Привет, {name}!");

        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: лучшая книга (ввод строки с клвиатуры и вывод сообщения)
        Console.WriteLine("Пример 2: лучшая книга");
        Console.Write("Введите название книги и нажмите Enter: ");
        string book = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{book} - лучшая книга!");

        Console.WriteLine();

        // Пример 3: повторение строк (ввод трех строк с клавиатуры и вывод сообщения)
        Console.WriteLine("Пример 3: Повторяшка");
        Console.WriteLine("Необходимо ввести три любых слова или коротких фразы.");
        Console.WriteLine("Введите первое слово или фразу и нажмите Enter: ");
        string first = Console.ReadLine();
        Console.WriteLine("Введите второе слово или фразу и нажмите Enter: ");
        string second = Console.ReadLine();
        Console.WriteLine("Введите третье слово или фразу и нажмите Enter: ");
        string third = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{first}\n{second}\n{third}");

        Console.WriteLine();

        // Пример 4: обратный порядок (ввод трех строк с клавиатуры и вывод сообщения)
        Console.WriteLine("Пример 4: обратный порядок");
        Console.WriteLine("Необходимо ввести три любых слова или коротких фразы.");
        Console.WriteLine("Введите первое слово или фразу и нажмите Enter: ");
        string firstA = Console.ReadLine();
        Console.WriteLine("Введите второе слово или фразу и нажмите Enter: ");
        string secondA = Console.ReadLine();
        Console.WriteLine("Введите третье слово или фразу и нажмите Enter: ");
        string thirdA = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{thirdA}\n{secondA}\n{firstA}");

        Console.WriteLine();

        // Пример 5: пользовательский разделитель
        Console.WriteLine("Пример 5: пользовательский разделитель");
        Console.WriteLine("Необходимо ввести разделитель (символы, цифры, буквы и т.д.) и три любых слова или коротких фразы.");
        Console.WriteLine("Введите разделитель и нажмите Enter: ");
        string separator = Console.ReadLine();
        Console.WriteLine("Введите первое слово или фразу и нажмите Enter: ");
        string firstB = Console.ReadLine();
        Console.WriteLine("Введите второе слово или фразу и нажмите Enter: ");
        string secondB = Console.ReadLine();
        Console.WriteLine("Введите третье слово или фразу и нажмите Enter: ");
        string thirdB = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{firstB}{separator}{secondB}{separator}{thirdB}");
    }
}
