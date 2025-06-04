// Примеры ввода целых чисел и 
// арифметических операций с ними на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class IntegerExamplesMicrosoftLearn
{
    public static void Main()
    {
      
        // Пример 1: оператор сложения +
        Console.WriteLine("Пример 1");
        int firstNumber = 12;
        int secondNumber = 7;
        Console.WriteLine(firstNumber + secondNumber); // output: 19
        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: объединение двух операндов (string и int)
        Console.WriteLine("Пример 2");
        string firstName = "Bob";
        int widgetsSold = 7;
        Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // output: Bob sold 7 widgets.
        Console.WriteLine();

        // Пример 3: сложение чисел и конкантенация строк
        Console.WriteLine("Пример 3");
        string firstName3 = "Bob";
        int widgetsSold3 = 7;
        Console.WriteLine(firstName3 + " sold " + widgetsSold3 + 7 + " widgets."); // output: Bob sold 77 widgets.
        Console.WriteLine();

        // Пример 4: использование скобок для уточнения действий компилятора
        Console.WriteLine("Пример 4");
        string firstName4 = "Bob";
        int widgetsSold4 = 7;
        Console.WriteLine(firstName4 + " sold " + (widgetsSold4 + 7) + " widgets."); // output: Bob sold 14 widgets.
        Console.WriteLine();

        // Пример 5: основные математические операции
        Console.WriteLine("Пример 5");
        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;
        int quotient = 7 / 5;
        Console.WriteLine("Sum: " + sum);               // output: Sum: 12
        Console.WriteLine("Difference: " + difference); // output: Difference: 2
        Console.WriteLine("Product: " + product);       // output: Product: 35
        Console.WriteLine("Quotient: " + quotient);     // output: Quotient: 1 (значение только целой части без дробной)
        Console.WriteLine();

        // Пример 6: порядок математических операций
        Console.WriteLine("Пример 6");
        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5;
        Console.WriteLine(value1); // output: 23
        Console.WriteLine(value2); // output: 35
        Console.WriteLine();
    }
} 
