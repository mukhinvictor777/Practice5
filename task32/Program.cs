int[] getRandomArray (int Length, int startPoint, int endPoint)
{   
    int [] resultArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;  
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }       
    }
    Console.WriteLine("]");
}

int[] getInversionArray (int[] incomingArray)
{
  
    for (int i = 0; i < incomingArray.Length; i++)
    {
        incomingArray[i] = incomingArray[i] * -1;
    }
    return incomingArray;
}

int [] currentArray = getRandomArray (10, -9, 9);
Console.WriteLine();
printArray(currentArray);
int [] inversionArray = getInversionArray(currentArray);
Console.WriteLine();
printArray(inversionArray);
Console.WriteLine();