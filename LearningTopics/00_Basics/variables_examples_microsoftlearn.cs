// Примеры работы с переменными на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class variablesExamplesMicrosoftLearn
{
    public static void Main()
    {

      // Пример 1: переназначение значения переменной int
      Console.WriteLine("Пример 1: переназначение значения переменной");
      // Объявляем переменную и присваиваем ей значение
      int score = 10;
      Console.WriteLine($"Начальный счёт: {score}");
      // Переназначаем новое значение
      score = 25;
      Console.WriteLine($"Обновлённый счёт: {score}");
      Console.WriteLine();
      
      // Пример 2: переназначение значения переменной string
      Console.WriteLine("Пример 2: переназначение значения переменной");
      string firstName;
      firstName = "Bob";
      Console.WriteLine(firstName);
      firstName = "Liem";
      Console.WriteLine(firstName);
      firstName = "Isabella";
      Console.WriteLine(firstName);
      firstName = "Yasmin";
      Console.WriteLine(firstName);
      Console.WriteLine();

      // Пример 3: неявно типизированная локальная переменная var
      // Ключевое слово var говорит компилятору: определи тип сам на основе присвоения значения
      // Ключевое слово var будет встречаться при чтении чужого кода,
      // НО!!! по возможности следует всегда использовать явный тип данных (int, string, double и т.д.).
      Console.WriteLine("Пример 3: переменная var");
      var age = 30;  // Компилятор определит тип как int
      Console.WriteLine($"Возраст: {age}");

      var name = "Алиса";  // Компилятор определит тип как string
      Console.WriteLine($"Имя: {name}");

      var temperature = 36.6;  // Компилятор определит тип как double
      Console.WriteLine($"Температура: {temperature}");

      Console.WriteLine();
    }
}
