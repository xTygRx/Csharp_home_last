// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadInt(string str)
{
    System.Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));

    
}
    

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
int funcAkker = Akkerman(M, N);
System.Console.WriteLine(funcAkker);
