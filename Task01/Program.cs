//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


int ReadInt(string str)
{
    System.Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int M, int N)
{
    if(M < N) return;
    PrintNumbers(M - 1, N);
    System.Console.Write(M + " ");
}

// ------------------
int M = ReadInt("Введите число M: ");

int N = ReadInt("Введите число N: ");

System.Console.WriteLine("На отрезке расположены следующие числа");
if (M > N) PrintNumbers(M, N);
else PrintNumbers(N, M);