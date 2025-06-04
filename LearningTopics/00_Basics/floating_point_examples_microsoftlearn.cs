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
        // Чтобы создать float литерал, добавьте после числа букву F или f
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
        // Чтобы создать decimal литерал, добавьте букву M или m после числа
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
        Console.WriteLine();

        // Пример 6: тип decimal
        Console.WriteLine("Пример 6: тип decimal");
        decimal decimalQuotient = 7.0m / 5;
        // decimal decimalQuotient = 7 / 5.0m; аналогичный способ записи
        // decimal decimalQuotient = 7.0m / 5.0m; аналогичный способ записи
        Console.WriteLine($"Decimal quotient: {decimalQuotient}"); // output: Decimal quotient: 1.4
        Console.WriteLine();
        // !!!Следующие строки кода не будут работать или будут давать неточные результаты
        // !!! int decimalQuotient = 7 / 5.0m;
        // !!! int decimalQuotient = 7.0m / 5;
        // !!! int decimalQuotient = 7.0m / 5.0m;
        // !!! decimal decimalQuotient = 7 / 5;

        // Пример 7: добавление кода для приведения результатов целочисленного деления
        Console.WriteLine("Пример 7: добавление кода для приведения результатов целочисленного деления");
        int first = 7;
        int second = 5;
        decimal quotient = (decimal)first / (decimal)second;
        Console.WriteLine(quotient); // output: 1.4
        Console.WriteLine();

        // Пример 8: определение оставшейся части после целочисленного деления
        Console.WriteLine("Пример 8: определение оставшейся части после целочисленного деления");
        Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // output: Modulus of 200 / 5 : 0
        Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");     // output: Modulus of 7 / 5 : 2
        Console.WriteLine();
    }
}

