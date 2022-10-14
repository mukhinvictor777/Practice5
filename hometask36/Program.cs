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

int sumOfEvenPositionNumbers (int[] incomingArray)
{
    int sum = 0;
    for (int i = 1; i < incomingArray.Length; i = i + 2)
    {
        sum = sum + incomingArray[i];
    }
    return sum;
}  

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
int [] randomArray = getRandomArray(arrayLenght, startPoint, endPoint);
int result = sumOfEvenPositionNumbers (randomArray);
Console.Write("В массиве: ");
printArray(randomArray);
Console.Write($" сумма чисел, стоящих на нечетных позициях равна {result}");
Console.WriteLine();