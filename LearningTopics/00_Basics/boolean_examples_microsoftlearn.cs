// Примеры работы с логическими литералами на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class booleanExamplesMicrosoftLearn
{
    public static void Main()
    {

        // Пример 1: логический литерал true
        Console.WriteLine("Пример 1: логический литерал true");
        bool isSunny = true;
        Console.WriteLine($"Сегодня солнечно? {isSunny}");
        Console.WriteLine();

        // Пример 2: логический литерал false
        Console.WriteLine("Пример 2: логический литерал false");
        bool isWeekend = false;
        Console.WriteLine($"Сегодня выходной? {isWeekend}");
        Console.WriteLine();

        // Пример 3: логические значение как результат сравнения
        Console.WriteLine("Пример 3: логические значение как результат сравнения");
        int age = 16;
        bool isAdult = age >= 18;
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Совершеннолетний? {isAdult}");
        Console.WriteLine();

        // Пример 4: логическое выражение сохраняется в переменную
        Console.WriteLine("Пример 4: сравнение чисел");
        int a = 10;
        int b = 5;
        bool aIsGreater = a > b;
        Console.WriteLine($"Число a больше b? {aIsGreater}");
        Console.WriteLine();
    }
}
