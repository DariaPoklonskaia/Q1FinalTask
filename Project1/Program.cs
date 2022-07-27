string [] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = string.Empty;
    }
    return newArray;
}

string [] FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i+1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


int CountElementsLenghtLess3 (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] MainTaskFillOutputArray (string[] arrayInput, string[] arrayOutput)
{
    int k = 0;
    for (int i = 0; i < arrayInput.Length; i ++)
    {
        if (arrayInput[i].Length <=3)
        {
            arrayOutput[k] = arrayInput[i];
            k++;
        }

    }
    return arrayOutput;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ,");
    }
    Console.WriteLine();
}