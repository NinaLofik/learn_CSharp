// Примеры анализа цифр целых чисел
// с помощью операций целочисленного деления ( / )
// и остатка от деления ( % ) на C#,
// написанные в процессе прохождения курса (Stepik).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class IntegerDigitAnalysisExamplesStepik
{
    public static void Main()
    {
      // Пример 1: вывод последней цифры натурального числа
      Console.WriteLine("Пример 1: вывод последней цифры натурального числа");
      Console.Write("Введите целое число и нажмите Enter: ");
      int number = Convert.ToInt32(Console.ReadLine());
      int lastDigit = number % 10;
      Console.WriteLine(); // пустая строка для отделения вывода
      Console.WriteLine($"Последняя цифра числа: {lastDigit}");

      Console.WriteLine(); // пустая строка для отделения примеров

      // Пример 2: вывод второй цифры справа (числа десятков)
      Console.WriteLine("Пример 2: вывод второй цифры справа (числа десятков)");
      Console.Write("Введите целое число и нажмите Enter: ");
      int number2 = Convert.ToInt32(Console.ReadLine());
      int tensDigit = (number2 / 10) % 10;
      Console.WriteLine();
      Console.WriteLine($"Цифра в разряде десятков: {tensDigit}");

      Console.WriteLine();

      // Пример 3: сумма цифр трёхзначного числа
      Console.WriteLine("Пример 3: сумма цифр трёхзначного числа");
      Console.Write("Введите трёхзначное число и нажмите Enter: ");
      int number3 = Convert.ToInt32(Console.ReadLine());
      int sumOfDigits = (number3 % 10) + ((number3 / 10) % 10) + ((number3 / 100) % 10);
      Console.WriteLine();
      Console.WriteLine($"Сумма цифр числа: {sumOfDigits}");

      Console.WriteLine();

      // Пример 4: перевернутое трёхзначное число
      Console.WriteLine("Пример 4: перевернутое трёхзначное число, не оканчивающееся на ноль");
      Console.Write("Введите трёхзначное число, не оканчивающееся на ноль, и нажмите Enter: ");
      int number4 = Convert.ToInt32(Console.ReadLine());
      int digit1 = number4 % 10;          // единицы
      int digit2 = (number4 / 10) % 10;   // десятки
      int digit3 = (number4 / 100) % 10;  // сотни
      Console.WriteLine();
      Console.WriteLine($"Перевернутое число: {digit1}{digit2}{digit3}");

      Console.WriteLine();

    }
}
