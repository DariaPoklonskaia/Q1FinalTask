string [] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
         newArray[i] = Console.ReadLine(); 
    }
    return newArray;
}

int CountElementsLengthLess3 (string[] array)
{
    int elementsCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) elementsCounter++;
    }
    return elementsCounter;
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
        Console.Write(array[i] + ",");
    }
    Console.WriteLine();
}


int randomMin = 1;
int randomMax = 9;
int inputArraySize = new Random().Next(randomMin, randomMax + 1); 
Console.WriteLine("You need to fill in array that consist of " + inputArraySize + " elements");

string[] userInputArray = CreateStringArray(inputArraySize);

int countElementsLess3 = CountElementsLengthLess3(userInputArray);

if (countElementsLess3 > 0)
    {
    string[] userOutputArray = MainTaskFillOutputArray(userInputArray, countElementsLess3);
    PrintArray(userInputArray);
    PrintArray(userOutputArray);
    }
else 
{
    PrintArray(userInputArray);
    Console.WriteLine("there are no elements for output array that meet conditions");
}


 



 







