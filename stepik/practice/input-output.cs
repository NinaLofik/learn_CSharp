// Примеры ввода и вывода данных в C#
// Examples of basic input and output in C#

using System;

public class InputOutput
{
    public static void Main()
    {
        // =====================================
        // Пример 1: Ввод названия книги
        // Example 1: Asking for the user's name
        // =====================================
        Console.Write("Введите ваше имя: ");  // Подсказка пользователю / Prompt the user
        string name = Console.ReadLine();     // Считываем ввода / Read the input
        Console.WriteLine($"Привет, {name}"); // Выводим сообщения / Output the message

        
        // =====================================
        // Пример 2: Ввод названия книги
        // Example 2: Asking for a favorite book
        // =====================================
        Console.Write("Введите название книги: ");    // Подсказка пользователю / Prompt the user
        string book = Console.ReadLine();             // Считываем названия книги / Read the book title
        Console.WriteLine($"{book} - лучшая книга!"); // Выводим сообщение / Output the message

        
        // =====================================
        // Пример 3: Считывание и вывод трёх строк
        // (точное повторение ввода пользователя)
        // Example 3: Reading and printing three lines
        // (exact repetition of user input)
        // =====================================
        Console.WriteLine("Введите три строки: ");              // Подсказка пользователю / Prompt the user
        string first = Console.ReadLine();                      // 
        string second = Console.ReadLine();                     // Считываем три строки подряд /  Read three lines in a row
        string third = Console.ReadLine();                      //
        Console.WriteLine(first + "\n" + second + "\n"+ third); // Выводим каждую строку на новой строке / Output each line on a new line

        
        // =====================================
        // Пример 4: Считывание и вывод трёх строк
        // в обратной последовательности
        // Example 4: Read and output three lines
        // in reverse order
        // =====================================
        Console.WriteLine("Введите три строки: ");                 // Подсказка пользователю / Prompt the user
        string firstA = Console.ReadLine();                        //
        string secondA = Console.ReadLine();                       // Считываем три строки подряд /  Read three lines in a row
        string thirdA = Console.ReadLine();                        //  
        Console.WriteLine(thirdA + "\n" + secondA + "\n" + firstA);// Выводим каждую строку на новой строке в обратной последовательности / We output each line on a new line in reverse order

        
        // =====================================
        // Пример 5: Кастомный разделитель
        // Example 5: Custom separator
        // =====================================
        Console.WriteLine("Введите четыре строки (первая - разделитель и три строки): "); // Подсказка пользователю / Prompt the user
        string separator = Console.ReadLine();                                            // Считываем разделитель / Read the custom separator
        string firstB = Console.ReadLine();                                               //
        string secondB = Console.ReadLine();                                              // Считываем три строки подряд /  Read three lines in a row
        string thirdB = Console.ReadLine();                                               //
        Console.WriteLine(firstB + separator + secondB + separator + thirdB);             // Выводим три строки, соединённые заданным разделителем / Output three strings joined by the separator
    }
}

