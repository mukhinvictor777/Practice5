int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 && result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && result < 1) Console.WriteLine($"Введите целое число больше нуля, вы вввели {userLine}"); else break;
    }
    return result;
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
    Console.Write("]");
}

int [] getRandomArray(int arrayLenght, int startPoint, int endPoint)
{
    int [] randomArray = new int [arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        randomArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return randomArray;
}

int CountOfEvenNumbers (int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}  

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int [] randomArray = getRandomArray(arrayLenght, 1, 999);
int result = CountOfEvenNumbers (randomArray);
Console.Write("В массиве: ");
printArray(randomArray);
Console.Write($" количество четных чисел равно {result}");
Console.WriteLine();
