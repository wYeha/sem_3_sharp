// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введи пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

void IfPol(int number_f)
{
    if (10000 <= number_f && number_f < 100000)
    {
        int start_number, summ = 0, cutted_number;
        for (start_number = number_f; number_f != 0; number_f /= 10)
        {
            cutted_number = number_f % 10;
            summ = summ * 10 + cutted_number;
        }
        if (start_number == summ) Console.WriteLine($"{start_number} - палиндром");
        else Console.WriteLine($"{start_number} - не палиндром!");

    }
    else Console.Write("Пя ти знач но е!!");
}

IfPol(number);