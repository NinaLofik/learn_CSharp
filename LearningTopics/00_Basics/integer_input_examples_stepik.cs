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
        Console.Write("Введите целое число и нажмите Enter: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(); // пустая строка для отделения вывода
        Console.WriteLine($"Квадрат числа: {number * number}");

        Console.WriteLine(); // пустая строка для отделения примеров

        // Пример 2: перевод метров в километры
        Console.WriteLine("Пример 2: перевод метров в полные километры");
        Console.Write("Введите количество метров и нажмите Enter: ");
        int meters = Convert.ToInt32(Console.ReadLine());
        int kilometers = meters / 1000;
        Console.WriteLine();
        Console.WriteLine($"Полных километров: {kilometers}");

        Console.WriteLine();

        // Пример 3: Произведение трёх чисел
        Console.WriteLine("Пример 3: произведение трёх чисел");
        
        Console.Write("Введите первое число и нажмите Enter: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите второе число и нажмите Enter: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите третье число и нажмите Enter: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        int product = number1 * number2 * number3;
        Console.WriteLine();
        Console.WriteLine($"Произведение: {product}");

        Console.WriteLine();

        // Пример 4: Делим яблоки поровну между школьниками
        Console.WriteLine("Пример 4: Делим яблоки поровну между школьниками");
        
        Console.Write("Введите количество школьников и нажмите Enter: ");
        int students = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите количество яблок и нажмите Enter: ");
        int apples = Convert.ToInt32(Console.ReadLine());
        
        int applesPerStudent = apples / students;
        Console.WriteLine();
        Console.WriteLine($"Каждому школьнику достанется: {applesPerStudent}");

        Console.WriteLine();

        // Пример 5: Сколько яблок останется в корзине
        Console.WriteLine("Пример 5: Сколько яблок останется в корзине");
        
        Console.Write("Введите количество школьников и нажмите Enter: ");
        int students1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите количество яблок и нажмите Enter: ");
        int apples1 = Convert.ToInt32(Console.ReadLine());
        
        int applesPerStudent1 = apples1 % students1;
        Console.WriteLine();
        Console.WriteLine($"Остаток яблок в корзине: {applesPerStudent1}");

        Console.WriteLine();

        // Пример 6: три последовательных числа
        Console.WriteLine("Пример 6: вывод трёх последовательных чисел");
        Console.Write("Введите число и нажмите Enter: ");
        int numberFirst = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();   
        Console.WriteLine(numberFirst++);
        Console.WriteLine(numberFirst++);
        Console.WriteLine(numberFirst++);

        Console.WriteLine();
        
        // Пример 7: расчёт стоимости N комплектов телефона
        Console.WriteLine("Пример 7: расчет стоимости всех комплектов телефона");
        
        Console.Write("Введите стоимость устройства и нажмите Enter: ");
        int cost1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите стоимость чехла и нажмите Enter: ");
        int cost2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите стоимость зарядки и нажмите Enter: ");
        int cost3 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите стоимость наушников и нажмите Enter: ");
        int cost4 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите количество комплектов телефона и нажмите Enter: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();   
        Console.WriteLine($"Стоимость {n} полных комплектов: {(cost1 + cost2 + cost3 + cost4) * n}");

        Console.WriteLine();
        
        // Пример 8: расчет стоимости N пирожков
        Console.WriteLine("Пример 8: расчет стоимости всех пирожков");
        
        Console.Write("Введите цену пирожка в рублях (без копеек) и нажмите Enter: ");
        int rubles = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите цену пирожка в копейках (без рублей) и нажмите Enter: ");
        int kopecks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество пирожков и нажмите Enter: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        int totalInKopecks = (rubles * 100 + kopecks) * n1;
        int totalRubles = totalInKopecks / 100;
        int totalKopecks = totalInKopecks % 100;
        Console.WriteLine();   
        Console.WriteLine($"Общая стоимость {n1} пирожков: {totalRubles} руб. {totalKopecks} коп.");

        Console.WriteLine();
        
        // Пример 9: пересчет временного интервала
        Console.WriteLine("Пример 9: пересчет минут в часы и минуты");
        Console.Write("Введите количество минут и нажмите Enter: ");
        int totalMinutes = Convert.ToInt32(Console.ReadLine());

        int hour = totalMinutes / 60;
        int minutes = totalMinutes % 60;

        Console.WriteLine();   
        Console.WriteLine($"{totalMinutes} мин - это {hour} час {minutes} мин.");

        Console.WriteLine();
        
        // Пример 10: следующее и предыдущее числа
        Console.WriteLine("Пример 10: вывод предыдущего и следующего числа");
        Console.Write("Введите целое число и нажмите Enter: ");
        int numberStart = Convert.ToInt32(Console.ReadLine());

        int numberNext = numberStart + 1;
        int numberPrevious = numberStart - 1;

        Console.WriteLine();   
        Console.WriteLine($"Следующее за числом {numberStart} число: {numberNext}");
        Console.WriteLine($"Для числа {numberStart} предыдущее число: {numberPrevious}");

    }
}
