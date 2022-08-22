// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int[] array = new int[5]; // ограничил кол-во элементов в будущем рандомном массиве до 5
int k = 0;
Random arrayRnd = new Random();

Console.WriteLine("Вывести рандомный массив:");

void ConclArr()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = arrayRnd.Next(100, 999); // кладем в массив случайные целые числа 
        Console.Write("{0} ", array[i]);
    }
}

void EvenElem()
{
    foreach(int element in array)
    {
        if (element % 2 == 0)
        {
            k++;
        }
    }
    Console.WriteLine("Количество четных элементов {0}", k);
}

ConclArr();
EvenElem();
