// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] arrNumbers = new double[7];
Random arrRnd = new Random();
double diff = 0;

Console.WriteLine("Массив вещественных чисел: ");

void PrintArrNumbers()
{
    for(int i = 0; i < arrNumbers.Length; i++)
    {
        arrNumbers[i] = arrRnd.Next(-10, 10);
        Console.Write("{0} ", arrNumbers[i]);
    }
    return;
}

void DifferenceNum()
{
    var max = arrNumbers[0];
    var min = arrNumbers[0];
    for(int i = 0; i < arrNumbers.Length; i++)
    {
        if(arrNumbers[i] >= max)
        {
            max = arrNumbers[i];
        }
        else if (arrNumbers[i] <= min)
        {
            min = arrNumbers[i];
        }
    }
    diff = max - min;
    Console.WriteLine("Разница между max элементом и min элементом: {0}", diff);
}

PrintArrNumbers();
Console.WriteLine();
DifferenceNum();