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

int CountElementsInArrayOut(string[] arrayIn)
{
    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
            count++;
    }
    return count;
}

void CreateOutputArray(string[] arrayIn, string[] arrayOut)
{
    int index = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[index] = arrayIn[i];
            index++;
        }
    }
}

void PrintArray(string[] arrayOut)
{
    Console.Write(" [");
    for (int i = 0; i < arrayOut.Length - 1; i++)
    {
        Console.Write($"{arrayOut[i]}, ");
    }
    Console.Write($"{arrayOut[arrayOut.Length - 1]}");
    Console.WriteLine("] ");
}

int length = InputNum("Введите размер массива: ");
string[] myArray1 = CreateInputArray(length);
FillArray(myArray1);

int count = CountElementsInArrayOut(myArray1);

if (count == 0)
{
    Console.Write("Элементов, удовлетворяющих условию, в массиве нет..");
}
else
{
    string[] myArray2 = CreateInputArray(count);
    CreateOutputArray(myArray1, myArray2);
    PrintArray(myArray2);
}
