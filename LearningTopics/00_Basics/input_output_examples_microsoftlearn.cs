// Примеры ввода и вывода данных на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class InputOutputExamplesMicrosoftLearn
{
    public static void Main()
    {
      // Пример 1: отображение литеральных и переменных значений
      Console.WriteLine("Пример 1: отображение литеральных и переменных значений");
      string name = "Bob";
      int messages = 3;
      decimal temperature = 34.4m;

      Console.Write("Hello, ");
      Console.Write(name);
      Console.Write("! You have ");
      Console.Write(messages);
      Console.Write(" messages in your inbox. The temperature is ");
      Console.Write(temperature);
      Console.Write(" celsius.");

      Console.WriteLine();
    }
}
