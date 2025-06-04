// Примеры проектов для практики базовых знаний на C#,
// написанные в процессе прохождения курса (Microsoft Learn).
// Все примеры объединены в один класс
// для удобства тестирования.

using System;

public class projectsBasicsExamplesMicrosoftLearn
{
    public static void Main()
    {
      // Пример 1: расчет и вывод на печать оценок учащихся
        Console.WriteLine("Пример 1: расчет и вывод на печать оценок учащихся");
        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
        decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
        decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
        decimal jeongScore = (decimal) jeongSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
        Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
        Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
        Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

        // output:
        // Student         Grade
        //
        // Sophia:         94.6    A
        // Nicolas:        83.6    B
        // Zahirah:        83.4    B
        // Jeong:          95.4    A
        Console.WriteLine();

        // Пример 2: вычисление окончательного GPA
        Console.WriteLine("Пример 2: вычисление окончательного GPA");
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

        int leadingDigit = (int) gradePointAverage;
        int firstDigit = (int) (gradePointAverage * 10 ) % 10;
        int secondDigit = (int) (gradePointAverage * 100 ) % 10;

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

        Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

        Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");
        // output:
        // Student: Sophia Johnson
        //
        // Course              Grade   Credit Hours	
        // English 101         4       3
        // Algebra 101         3       3
        // Biology 101         3       4
        // Computer Science I  3       4
        // Psychology 101      4       3
        // 
        // Final GPA:          3.35
    }
}
