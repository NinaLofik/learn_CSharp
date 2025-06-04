// Примеры для инкрементов и декрементов на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class IncrementDecrementExamplesMicrosoftLearn
{
    public static void Main()
    {
        // Пример 1: Увеличение и уменьшение
        // int value = 0;     // value is now 0.
        // value = value + 5; // value is now 5.
        // value += 5;        // value is now 10.

        // int value = 0;     // value is now 0.
        // value = value + 1; // value is now 1.
        // value++;           // value is now 2.
        Console.WriteLine("Пример 1: увеличение и уменьшение");
        int value1 = 1;
        value1 = value1 + 1;
        Console.WriteLine("First increment: " + value1);  // output: First increment: 2
        value1 += 1;
        Console.WriteLine("Second increment: " + value1); // output: Second increment: 3
        value1++;
        Console.WriteLine("Third increment: " + value1);  // output: Third increment: 4
        value1 = value1 - 1;
        Console.WriteLine("First decrement: " + value1);  // output: First decrement: 3
        value1 -= 1;
        Console.WriteLine("Second decrement: " + value1); // output: Second decrement: 2
        value1--;
        Console.WriteLine("Third decrement: " + value1);  // output: Third decrement: 1
        Console.WriteLine();
        
        // Пример 2: расположение операторов инкремента
        // В зависимости от своего положения, инкремент и декремент 
        // выполняют свою операцию до или после получения значения.
        // Другими словами, если оператор используется перед значением, как и в ++value,
        // то добавочный шаг будет происходить перед получением значения.
        // Аналогичным образом значение будет увеличено с помощью value++ после его получения.
        Console.WriteLine("Пример 2: расположение операторов инкремента");
        int value2 = 1;
        value2++;
        Console.WriteLine("First: " + value2);      // output: First: 2
        Console.WriteLine($"Second: {value2++}");   // output: Second: 2
        Console.WriteLine("Third: " + value2);      // output: Third: 3
        Console.WriteLine("Fourth: " + (++value2)); // output: Fourth: 4
        Console.WriteLine();

        // Пример 3: постфиксный инкремент
        Console.WriteLine("Пример 3: постфиксный инкремент (x++)");
        int a = 1;
        Console.WriteLine($"Начальное значение a: {a}");
        Console.WriteLine($"Вывод с постфиксным инкрементом a++: {a++}");
        Console.WriteLine($"Значение a после инкремента: {a}");
        Console.WriteLine();

        // Пример 4: префиксный инкремент
        Console.WriteLine("Пример 4: префиксный инкремент (++x)");
        int b = 1;
        Console.WriteLine($"Начальное значение b: {b}");
        Console.WriteLine($"Вывод с префиксным инкрементом ++b: {++b}");
        Console.WriteLine($"Значение b после инкремента: {b}");
        Console.WriteLine();

        // Пример 5: постфиксный декремент
        Console.WriteLine("Пример 5: постфиксный декремент (x--)");
        int c = 3;
        Console.WriteLine($"Начальное значение c: {c}");
        Console.WriteLine($"Вывод с постфиксным декрементом c--: {c--}");
        Console.WriteLine($"Значение c после декремента: {c}");
        Console.WriteLine();

        // Пример 6: префиксный декремент
        Console.WriteLine("Пример 6: префиксный декремент (--x)");
        int d = 3;
        Console.WriteLine($"Начальное значение d: {d}");
        Console.WriteLine($"Вывод с префиксным декрементом --d: {--d}");
        Console.WriteLine($"Значение d после декремента: {d}");
        Console.WriteLine();
    }
} 
