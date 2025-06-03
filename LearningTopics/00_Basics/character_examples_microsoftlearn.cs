// Примеры для символьных литералов на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class characterExamplesMicrosoftLearn
{
    public static void Main()
    {
      
      // Пример 1: символьный литерал
      Console.WriteLine("Пример 1: символьный литерал");

      char letter = 'A'; // литерал одного символа заключён в одинарные кавычки
      Console.WriteLine($"Символ: {letter}");

      char symbol = '#'; // любой символ, включая спец.символы
      Console.WriteLine($"Символ: {symbol}");
      
      Console.WriteLine(); // пустая строка для отделения вывода
    }
}
