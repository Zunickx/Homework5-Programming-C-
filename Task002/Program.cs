// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int[] arrayOne = new int [7];
Random arrayRnd = new Random();
int sum = 0;

Console.WriteLine("Вывести одномерный рандомный массив: ");

void OneDimenArr()
{
    for (int i = 0; i < arrayOne.Length; i++)
    {
        arrayOne[i] = arrayRnd.Next(0, 20);
        Console.Write("{0} ", arrayOne[i]);
    }
    return;
}

void SumOdd()
{
    for(int i = 0; i < arrayOne.Length; i++)
    {
        if(i % 2 != 0) sum += arrayOne[i];
    }
    Console.WriteLine("Сумма элементов на нечетных позициях: {0}", sum);
}

OneDimenArr();
Console.WriteLine();
SumOdd();
Console.WriteLine();
