// Примеры работы с литералами с плавающей запятой на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class floatingPointExamplesMicrosoftLearn
{
    public static void Main()
    {

        // Пример 1: тип float (одинарная точность)
        Console.WriteLine("Пример 1: тип float (одинарная точность)");
        float floatValue = 3.14159f;
        Console.WriteLine($"Значение float: {floatValue}");
        Console.WriteLine();

        // Пример 2: тип double (двойная точность)
        Console.WriteLine("Пример 2: тип double (двойная точность)");
        double doubleValue = 3.141592653589793;
        Console.WriteLine($"Значение double: {doubleValue}");
        Console.WriteLine();

        // Пример 3: тип decimal (высокая точность, для финансов)
        Console.WriteLine("Пример 3: тип decimal (высокая точность, для финансов)");
        decimal decimalValue = 3.1415926535897932384626433832m;
        Console.WriteLine($"Значение decimal: {decimalValue}");
        Console.WriteLine();

        // Пример 4: разница в точности (double vs decimal)
        Console.WriteLine("Пример 4: сравнение double и decimal при сложении");
        double a = 0.1;
        double b = 0.2;
        Console.WriteLine($"0.1 + 0.2 с double: {a + b}"); // Может быть не 0.3

        decimal c = 0.1m;
        decimal d = 0.2m;
        Console.WriteLine($"0.1 + 0.2 с decimal: {c + d}"); // Будет ровно 0.3
        Console.WriteLine();

        // Пример 5: округление float и decimal
        Console.WriteLine("Пример 5: округление float и decimal");
        float floatRounded = 1f / 3f;
        decimal decimalRounded = 1m / 3m;
        Console.WriteLine($"1 / 3 (float): {floatRounded}");
        Console.WriteLine($"1 / 3 (decimal): {decimalRounded}");
    }
}

