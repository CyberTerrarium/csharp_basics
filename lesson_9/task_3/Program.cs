// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int n, int m)
{
    while (n != 0)
    {
        m = m == 0 ? 1 : Ackerman(n, (m - 1));
        n--;
    }
    return m + 1;
}


int first = ReadInt("Введите 1е число: ");
int second = ReadInt("Введите 2е число: ");
System.Console.WriteLine();
System.Console.WriteLine(Ackerman(first, second));