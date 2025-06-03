// Примеры использования встроенного класса Math на C#,
// написанные в процессе прохождения курса (Stepik).
// Все примеры объединены в один класс
// для удобства тестирования.

// Важно!
// Класс Math содержит готовые методы для:
// - Math.Abs(x) — модуль (абсолютное значение)
// - Math.Sqrt(x) — квадратный корень
// - Math.Pow(x, y) — возведение в степень
// - Math.Min(a, b) и Math.Max(a, b) — минимум и максимум
// - Math.Round(x) и Math.Round(x, знаков) — округление по правилам математики
// Все методы возвращают результат типа `double` (если не указано иначе).
// Полный список всех функций класса Math с объяснениями: https://learn.microsoft.com/ru-ru/dotnet/api/system.math?view=net-9.0

using System;

public class MathClassExamplesStepik
{
    public static void Main()
    {
      // =============================================================================
      // Пример 1: перевод количества информации из бит в килобайты
      // 1Кбайт = 2^13 бит = 8192 бит
      Console.WriteLine("Пример 1: перевод количества информации из бит в килобайты");
      Console.Write("Введите количество информации в битах и нажмите Enter: ");
      int bits = Convert.ToInt32(Console.ReadLine());

      // переводим биты в килобайты (double для вещественного результата)
      double kilobytes = bits / Math.Pow(2, 13);
      
      Console.WriteLine(); // пустая строка для отделения вывода
      Console.WriteLine($"Количество информации в килобайтах: {kilobytes}");

      Console.WriteLine(); // пустая строка для отделения примеров

      // =============================================================================
      // Пример 2: вычисление периметра прямоугольного треугольника
      // по длинам катетов (a и b)
      Console.WriteLine("Пример 2: вычисление периметра прямоугольного треугольника");
      Console.Write("Введите длину первого катета и нажмите Enter: ");
      double a = Convert.ToDouble(Console.ReadLine());

      Console.Write("Введите длину второго катета и нажмите Enter: ");
      double b = Convert.ToDouble(Console.ReadLine());

      // вычисляем гипотенузу по теореме Пифагора: c = sqrt(a^2 + b^2)
      double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
      // Периметр треугольника - сумма всех сторон
      double perimeter = a + b + c;
      
      Console.WriteLine();
      Console.WriteLine($"Периметр треугольника: {perimeter}");

      Console.WriteLine();

      // =============================================================================
      // Пример 3: расстояние между двумя точками на плоскости
      Console.WriteLine("Пример 3: расстояние между двумя точками на плоскости");
      Console.Write("Введите координату x1 и нажмите Enter: ");
      int x1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату y1 и нажмите Enter: ");
      int y1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату x2 и нажмите Enter: ");
      int x2 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату y2 и нажмите Enter: ");
      int y2 = Convert.ToInt32(Console.ReadLine());

      // Вычисляем разности по осям
      int dx = x1 - x2;
      int dy = y1 - y2;

      // Вычисляем расстояние по формуле: √((x1 - x2)^2 + (y1 - y2)^2):
      double distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
      
      Console.WriteLine();
      Console.WriteLine($"Расстояние между точками: {distance}");

      Console.WriteLine();

      // =============================================================================
      // Пример 4: манхеттенское расстояние между двумя точками
      Console.WriteLine("Пример 4: манхеттенское расстояние между двумя точками");
      Console.Write("Введите координату x1 и нажмите Enter: ");
      int x11 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату y1 и нажмите Enter: ");
      int y11 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату x2 и нажмите Enter: ");
      int x22 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите координату y2 и нажмите Enter: ");
      int y22 = Convert.ToInt32(Console.ReadLine());

      // Вычисляем манхеттенское растояние: |x1 - x2| + |y1 - y2|
      int manhattanDistance = Math.Abs(x11 - x22) + Math.Abs(y11 - y22);

      Console.WriteLine();
      Console.WriteLine($"Манхеттенское расстояние: {manhattanDistance}");

      Console.WriteLine();

      // =============================================================================
      // Пример 5: нахождение максимальной цифры в трёхзначном числе (учитывая отрицательные значения)
      Console.WriteLine("Пример 5: нахождение максимальной цифры в трёхзначном числе");
      Console.Write("Введите трёхзначное число (может быть отрицательным) и нажмите Enter: ");
      int number5 = Convert.ToInt32(Console.ReadLine());
      
      // Берём модуль числа, чтобы избавиться от возможного минуса
      number5 = Math.Abs(number5);

      // Получаем цифры: первая, вторая, третья
      int firstDigit = number5 / 100;
      int secondDigit = (number5 / 10) % 10;
      int thirdDigit = number5 % 10;

      // Ищем максимальную из трёх
      int maxDigit = Math.Max(Math.Max(firstDigit, secondDigit), thirdDigit);

      Console.WriteLine();
      Console.WriteLine($"Максимальная цифра: {maxDigit}");
    }
}
