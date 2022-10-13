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

int getSumOfPositiveNumbersInArray(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] >= 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int getSumOfNegativeNumbersInArray(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] < 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int getSumOfPositiveOrNegativeNumbersInArray(int[] incomingArray, int deviation)
// deviation = 1 если нужно суммировать положительные элементы, -1 если нужно искать отрицательные)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] * deviation > 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}

int [] currentArray = getRandomArray (12, -9, 9);
Console.WriteLine();
printArray(currentArray);
int sumOfPositive = getSumOfPositiveNumbersInArray(currentArray);
int sumOfNegative = getSumOfNegativeNumbersInArray(currentArray);
Console.WriteLine($"Сумма положительных {sumOfPositive}, сумма отрицательных {sumOfNegative}");
sumOfNegative = getSumOfPositiveOrNegativeNumbersInArray(currentArray, -1);
sumOfPositive = getSumOfPositiveOrNegativeNumbersInArray(currentArray, 1);
Console.WriteLine($"Сумма положительных {sumOfPositive}, сумма отрицательных {sumOfNegative}");
Console.WriteLine();