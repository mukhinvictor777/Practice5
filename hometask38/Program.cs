double differenceOfMinMaxInArray (double [] incomingArray)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > max)
        {
            max = incomingArray[i];
        }
        if (incomingArray[i] < min)
        {
            min = incomingArray[i];
        }
    }
    double difference = max - min;
    return difference;
}

double [] getDoubleArrayFromUser()
{
    int userArrayLenght = getNumberFromUser ("Введите длину массива вещественных чисел: ");
    double [] userArray = new double[userArrayLenght];
    for (int i = 0; i < userArrayLenght; i++)
    {
        userArray[i] = getDoubleNumberFromUser ($"Введите {i+1} эелмент массива чисел: ");
    }
    Console.WriteLine("Вы задали следующий массив:");
    printArray(userArray);
    return userArray;
}

int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result < 1) Console.WriteLine($"Введите целое число больше нуля, вы вввели {userLine}"); else break;
    }
    return result;
}

double getDoubleNumberFromUser(string userInformation)
{
    double  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите число, вы вввели {userLine}"); else break;
    }
    return result;
}

void printArray(double[] incomingArray)
{
    Console.Write("[ ");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(" ");
        }       
    }
    Console.Write(" ]");
}

double [] userArray = getDoubleArrayFromUser();
double difference = differenceOfMinMaxInArray(userArray);
Console.WriteLine();
Console.Write("Разница между максимальным и минальным элементом в массиве ");
printArray(userArray);
Console.Write($" равна {difference}");
