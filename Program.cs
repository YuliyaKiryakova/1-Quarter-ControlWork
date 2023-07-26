int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string[] CreateInputArray(int size)
{
    return new string[size];
}

void FillArray(string[] arrayIn)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arrayIn[i] = Console.ReadLine()!;
    }
}

void CreateOutputArray(string[] arrayIn, string[] arrayOut)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
            arrayOut[i] = arrayIn[i];
    }
}

void PrintArray(string[] arrayOut)
{
    for (int i = 0; i < arrayOut.Length; i++)
    {
        Console.Write($"{arrayOut[i]} ");
    }
    Console.WriteLine();
}

int length = InputNum("Введите размер массива: ");
string[] myArray1 = CreateInputArray(length);
string[] myArray2 = CreateInputArray(length);
FillArray(myArray1);
CreateOutputArray(myArray1, myArray2);
PrintArray(myArray2);
