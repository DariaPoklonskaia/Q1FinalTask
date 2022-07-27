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


int CountElementsLengthLess3 (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] MainTaskFillOutputArray (string[] arrayInput, int count)
{
    string[] arrayOutput = new string[count];
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

int inputArraySize = new Random().Next(1, 10); // принятое допущение 3
Console.WriteLine("You need to fill in array that consist of " + inputArraySize + " elements");

string[] userInputArray = CreateStringArray(inputArraySize);

userInputArray = FillStringArray(userInputArray);

int countElementsLess3 = CountElementsLengthLess3(userInputArray);

string[] userArrayOutput = MainTaskFillOutputArray(userInputArray, countElementsLess3); 

PrintArray(userInputArray);

PrintArray(userArrayOutput); 







