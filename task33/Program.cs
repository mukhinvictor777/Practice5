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
    Console.Write("[ ");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }       
    }
    Console.WriteLine(" ]");
}

int [] getIntegerArrayFromUser()
{
    int userArrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
    int [] userArray = new int[userArrayLenght];
    for (int i = 0; i < userArrayLenght; i++)
    {
        userArray[i] = getNumberFromUser ($"Введите {i+1} эелмент массива целых чисел: ");
    }
    Console.WriteLine("Вы задали следующий массив:");
    printArray(userArray);
    return userArray;
}

void checkNumberInArray(int[] incomingArray, int number)
{
    int check = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] == number)
        {
            check = 1;
        }   
    }
    if (check == 1)
    {
        printArray(incomingArray);
        Console.Write("да");
    }
    else 
    {
    printArray(incomingArray);
    Console.Write("нет");
    }
}

int [] userArray = getIntegerArrayFromUser();
int number = getNumberFromUser ("Введите целое число для поиска в массиве: ");
checkNumberInArray(userArray, number);