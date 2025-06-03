// Примеры работы с вещественными числами (double) на C#,
// написанные в процессе прохождения курса (Stepik).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class floatingPointDoubleExamplesStepik
{
    public static void Main()
    {
      
      // Пример 1: площадь круга
      Console.WriteLine("Пример 1: площадь круга");
      Console.Write("Введите радиус круга и нажмите Enter: ");
      double radius = Convert.ToDouble(Console.ReadLine());
      double area = 3.14 * radius * radius;
      Console.WriteLine(); // пустая строка для отделения вывода
      Console.WriteLine($"Площадь круга с радиусом {radius} равна {area:F2}");

      Console.WriteLine(); // пустая строка для отделения примеров

      // Пример 2: площадь прямоугольного треугольника
      Console.WriteLine("Пример 2: вычисление площади прямоугольного треугольника");
      Console.Write("Введите длину первого катета и нажмите Enter: ");
      double a = Convert.ToDouble(Console.ReadLine());

      Console.Write("Введите длину второго катета и нажмите Enter: ");
      double b = Convert.ToDouble(Console.ReadLine());
      
      double area2 = 0.5 * a * b;
      Console.WriteLine();
      Console.WriteLine($"Площадь треугольника равна {area2}");

      Console.WriteLine();
      
      // Пример 3: перевод температуры из градусов Фаренгейта в Цельсии
      Console.WriteLine("Пример 3: перевод температуры из градусов Фаренгейта в Цельсии");
      Console.Write("Введите температуру в градусах по Фаренгейту и нажмите Enter: ");
      double f = Convert.ToDouble(Console.ReadLine());

      double c = 5.0 / 9.0 * (f - 32);
      Console.WriteLine();
      Console.WriteLine($"Температура по Цельсию: {c}");

      Console.WriteLine();

      // Пример 4: среднее арифметическое двух целых чисел
      Console.WriteLine("Пример 4: нахождение среднего арифметического двух целых чисел");
      Console.Write("Введите первое целое число и нажмите Enter: ");
      int first = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите второе целое число и нажмите Enter: ");
      int second = Convert.ToInt32(Console.ReadLine());
      // Чтобы избежать целочисленного деления, хотя оба числа целые (int),
      // нужно сделать одно из них double (или делить на 2.0). Иначе
      // результат тоже будет int, даже если вы его сохранили в переменной типа double.                                               
      Console.WriteLine();
      Console.WriteLine($"Среднее арифметическое: {(first + second) / 2.0}");

      Console.WriteLine();

      // Пример 5: нахождение дробной части положительного вещественного числа
      Console.WriteLine("Пример 5: нахождение дробной части положительного нецелого числа");
      Console.Write("Введите нецелое число (число с запятой) и нажмите Enter: ");
      double number5 = Convert.ToDouble(Console.ReadLine());
      
      double fractionalPart = number5 - (int)number5; 
      // (int)number5 отбрасывает дробную часть, оставляя только целую
      // number5 - (int)number5 дает нам именно дробную часть                                    
      Console.WriteLine();
      Console.WriteLine($"Дробная часть нецелого числа (значение после запятой): {fractionalPart}");
      // Возможны погрешности при выводе, например, вместо 3,2556 может быть 0,2555999999999998.
      // Чтобы избежать этого, можно позже добавить форматирование.
    }
}
