// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int CalcSumOfNumbersInRange(int rangeStart, int rangeEnd)
{
    return rangeStart > rangeEnd ? 0 : rangeStart + CalcSumOfNumbersInRange(rangeStart + 1, rangeEnd);
}

int start = ReadInt("Введите начало диапазона: ");
int end = ReadInt("Введите конец диапазона: ");
System.Console.WriteLine();
System.Console.WriteLine(CalcSumOfNumbersInRange(start, end));
