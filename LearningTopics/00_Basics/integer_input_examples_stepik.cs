// Примеры ввода и обработки целых чисел на C#,
// написанные в процессе прохождения курса (Stepik).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class IntegerInputExamplesStepik
{
    public static void Main()
    {
      
        // Пример 1: квадрат числа
        Console.WriteLine("Пример 1: квадрат числа");
        Console.Write("Введите целое число: "); 
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); // пустая строка для отделения вывода
        Console.WriteLine($"Квадрат числа: {number * number}");

        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: перевод метров в километры
        Console.WriteLine("Пример 2: перевод метров в полные километры");
        Console.Write("Введите количество метров: ");    
        int meters = Convert.ToInt32(Console.ReadLine());
        int kilometers = meters / 1000;
        Console.WriteLine();
        Console.WriteLine($"Полных километров: {kilometers}");

        Console.WriteLine();

        // Пример 3: Произведение трёх чисел
        Console.WriteLine("Пример 3: произведение трёх чисел");
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int product = number1 * number2 * number3;
        Console.WriteLine();
        Console.WriteLine($"Произведение: {product}");

        Console.WriteLine();

        // Пример 4: Делим яблоки поровну между школьниками
        Console.WriteLine("Пример 4: Делим яблоки поровну между школьниками");
        Console.Write("Введите количество школьников: ");
        int students = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество яблок: ");
        int apples = Convert.ToInt32(Console.ReadLine());
        int applesPerStudent = apples / students;
        Console.WriteLine();
        Console.WriteLine($"Каждому школьнику достанется: {applesPerStudent}");

        Console.WriteLine();

        // Пример 5:
      
    }
}
