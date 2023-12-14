//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] GenerateArray(int size, int leftRange, int rigthRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
        {
        tempArray[i] = rand.Next(leftRange, rigthRange + 1);
        }
    return tempArray;
}

void PrintArray(int[] array2){
    System.Console.WriteLine("[" + string.Join(", ", array2) + "]");
}

int ReadInt(string str)
{
    System.Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbersArray(int[] array, int size)
{
    
    if(size - 1 < 0 ) return;
    System.Console.Write(array[size-1] + " ");
    PrintNumbersArray(array, size - 1);
    
}


// ------------------


int size = ReadInt("Введите размер массива");
int[] array = GenerateArray(size, 1, 100);
System.Console.WriteLine("Исходный массив");
PrintArray(array);
System.Console.WriteLine("Элементы массива с конца");
PrintNumbersArray(array, size);

