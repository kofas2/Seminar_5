// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,20);
    }
}

void PrintArray(int []array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool CheckA(int a, int [] array)
{
    bool temp = false;

    foreach (int i in array)
    {
        if (i == a)
        {
            temp = true;
            break;
        }
    }
    return temp;

}


Console.WriteLine("Введите количество значений массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, чтобы узнать, присутствет ли оно в массиве");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
FillArray(array);
PrintArray(array);
Console.WriteLine($"{CheckA(a, array)}");
