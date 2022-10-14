int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите целое число, вы вввели {userLine}"); else break;
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

int getCountOfNumbers(int[] incomingArray)
{
    int count = 0;
    int startNumber = getNumberFromUser ("Введите минимальное число в диапазоне поиска: ");
    int endNumber = getNumberFromUser ("Введите максимальное число в диапазоне поиска: "); 
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] >= startNumber && incomingArray[i] <= endNumber) count++;
    }
    return count;
}

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
int [] randomArray = getRandomArray(arrayLenght, startPoint, endPoint);
printArray(randomArray);
Console.WriteLine("]");


int countOfNumbers = getCountOfNumbers(randomArray);
Console.WriteLine();
printArray(randomArray);
Console.Write($"] -> {countOfNumbers}");
Console.WriteLine();