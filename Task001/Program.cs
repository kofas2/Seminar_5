// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка
//  [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

void FillArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int [] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void Summa1(int [] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    foreach (int item in array)
    {
        if (item>0)
        {
            sumPositive += item;
        }
        else
        {
            sumNegative += item;
        }
    }
    Console.WriteLine($"Сумма положительных элементов равна: {sumPositive}");
    Console.WriteLine($"Сумма отрицательных элементов равна: {sumNegative}");
}


int[] Summa2(int [] array)
{
        int sumPositive = 0;
    int sumNegative = 0;
    foreach (int item in array)
    {
        if (item>0)
        {
            sumPositive += item;
        }
        else
        {
            sumNegative += item;
        }
    }
    int [] results = {sumPositive, sumNegative};
    return results;
}

int [] array = new int [12];
FillArray(array);
PrintArray(array);
Summa1(array);
int [] res = Summa2(array);
Console.WriteLine($"Сумма2 положительных элементов равна: {res[0]}");
Console.WriteLine($"Сумма2 отрицательных элементов равна: {res[1]}");