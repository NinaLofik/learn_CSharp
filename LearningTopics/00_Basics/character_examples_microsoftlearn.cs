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
        Console.WriteLine("Пример 1: обычный символьный литерал");
        char letter = 'A'; // литерал одного символа заключён в одинарные кавычки
        Console.WriteLine($"Символ: {letter}");
        char symbol = '#'; // любой символ, включая спец.символы
        Console.WriteLine($"Символ: {symbol}");
        Console.WriteLine(); // пустая строка для отделения вывода

        // Пример 2: символ с клавиатуры
        Console.WriteLine("Пример 2: ввод символа с клавиатуры");
        Console.Write("Введите любой символ и нажмите Enter: ");
        char inputChar = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Вы ввели символ: {inputChar}");
        Console.WriteLine();

        // Для удобства тестирования примеров в консоли (не пример)
        Console.Write("Нажмите Enter для перехода к примерам с 3 по 11 ");
        string pause = Console.ReadLine();
        Console.WriteLine(pause);
        
        // Пример 3: escape-последовательности
        Console.WriteLine("Пример 3: escape-последовательности");
        char newline = '\n';
        char tab = '\t';
        char quote = '\'';
        char slash = '\\';
        Console.WriteLine($"Символ новой строки: \\n -> [{newline}]");
        Console.WriteLine($"Символ табуляции: \\t -> [{tab}]");
        Console.WriteLine($"Одинарная кавычка: \\' -> {quote}");
        Console.WriteLine($"Одинарный слэш: \\\\ -> {slash}");
        Console.WriteLine();

        // Пример 4: escape-последовательности \", \n, \t, \\
        Console.WriteLine("Пример 4: escape-последовательности");
        Console.WriteLine("Hello\nWorld!");        // Hello
                                                   // World!       
        Console.WriteLine("Hello\tWorld!");        // Hello   World!
        Console.WriteLine("Hello \"World\"!");     // Hello "World"!
        Console.WriteLine("c:\\source\\repos");    // c:\source\repos
        Console.WriteLine();

        // Пример 5: форматирование выходных данных с помощью последовательностей escape-символов
        Console.WriteLine("Пример 5: форматирование выходных данных с помощью последовательностей escape-символов");
        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");
        // Generating invoices for customer "Contoso Corp" ...
        //
        // Invoice: 1021           Complete!
        // Invoice: 1022           Complete!
        //
        // Output Directory:
        // c:\invoices
        Console.WriteLine();
        Console.WriteLine();

        // Пример 6: обычный строковый литерал с экранированием
        Console.WriteLine("Пример 6: обычный строковый литерал с экранированием");
        string path1 = "C:\\Users\\Nina\\Documents\\file.txt";
        Console.WriteLine($"Путь: {path1}");
        Console.WriteLine();

        // Пример 7: строковый литерал verbatim
        Console.WriteLine("Пример 7: строковый литерал verbatim (с @)");
        string path2 = @"C:\Users\Nina\Documents\file.txt";
        Console.WriteLine($"Путь: {path2}");
        Console.WriteLine();

        // Пример 8: verbatim-строка с несколькими строками
        Console.WriteLine("Пример 8: многострочный текст в строковом литерале");
        string multiline = @"Это многострочный
    текст с сохранением
    всех переводов строк и отступов.";
        Console.WriteLine(multiline);
        Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
        Console.WriteLine();

        // Пример 9: как использовать двойные кавычки внутри verbatim
        Console.WriteLine("Пример 9: двойные кавычки внутри строки с @");
        string quote9 = @"Она сказала: ""Привет, мир!""";
        Console.WriteLine(quote9);
        Console.WriteLine();

        // Пример 10: символ Unicode
        Console.WriteLine("Пример 10: символ Unicode");
        char heart = '\u2665';
        Console.WriteLine($"Unicode-символ сердца: {heart}");
        Console.WriteLine();

        // Пример 11: символ Unicode с вводом кода
        Console.WriteLine("Пример 11: свой Unicode-символ по коду");
        Console.Write("Введите 4-значный код символа в 16-ричном формате (например, 263A для ☺): ");
        string code = Console.ReadLine();
        char customChar = (char)Convert.ToUInt16(code, 16);
        Console.WriteLine($"Символ по коду \\u{code}: {customChar}");
        Console.WriteLine();

        // Для удобства тестирования примеров в консоли (не пример)
        Console.Write("Нажмите Enter для перехода к примерам с 12 по 14 ");
        string pause1 = Console.ReadLine();
        Console.WriteLine(pause1);

        // Пример 12: escape-символы Юникода
        Console.WriteLine("Пример 12: escape-символы Юникода");
        // Kon'nichiwa World
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
        // В примерах здесь используется UTF-16
        // Символы Юникода могут не отображаться (будут стоять ??? вместо кода)
        // Этот пример в общих чертах описывает возможное использование символов Юникода
        // Тема (работа с символами Юникод) сложная и требует отдельного тщательного изучения
        Console.WriteLine();

        // Пример 13: форматирование выходных данных с помощью escape-символов Юникода
        Console.WriteLine("Пример 13: escape-символы Юникода");
        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");
        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // User command to run an application
        Console.WriteLine(@"c:\invoices\app.exe -j");
        // В примерах здесь используется UTF-16
        // Символы Юникода могут не отображаться (будут стоять ??? вместо кода)
        // Этот пример в общих чертах описывает возможное использование символов Юникода
        // Тема (работа с символами Юникод) сложная и требует отдельного тщательного изучения
        Console.WriteLine();

        // Пример 14: использование escape-последовательностей символов, string, Юникода и интерполяции строк
        Console.WriteLine("Пример 13: использование escape-последовательностей символов, string, Юникода и интерполяции строк");
        string projectName = "ACME";
        string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        Console.WriteLine();
    }
}
