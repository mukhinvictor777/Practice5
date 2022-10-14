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

int [] productOfCoupleOFNumbers(int[] incomingArray)
{
    int productOfCoupleOFNumbersLenght = incomingArray.Length / 2;
    if (incomingArray.Length % 2 != 0)
    {
        productOfCoupleOFNumbersLenght++;
    }
    int [] productOfCoupleOFNumbers = new int[productOfCoupleOFNumbersLenght];
    for (int i = 0; i < productOfCoupleOFNumbersLenght; i++)
    {
        productOfCoupleOFNumbers[i] = incomingArray[i] * incomingArray[incomingArray.Length-1-i];
    }
    
    if (incomingArray.Length % 2 != 0)
    {
        productOfCoupleOFNumbers[productOfCoupleOFNumbersLenght-1] = incomingArray[productOfCoupleOFNumbersLenght-1];
    } 
    return productOfCoupleOFNumbers;
}  

int arrayLenght = getNumberFromUser ("Введите длину массива целых чисел: ");
int startPoint = getNumberFromUser ("Задайте минимально возможное значение в массиве: ");
int endPoint = getNumberFromUser ("Задайте максимально возможное значение в массиве: ");
int [] randomArray = getRandomArray(arrayLenght, startPoint, endPoint);
printArray(randomArray);
Console.WriteLine();
int [] resultArray = productOfCoupleOFNumbers(randomArray);
printArray(resultArray);