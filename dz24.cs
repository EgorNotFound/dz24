/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка */

Console.WriteLine("Введите размер прямоугольного массива a x b и диапазон случайных значений:");
 Console.Write("Введите количество строк: ");
string userString = Console.ReadLine();
int a = Convert.ToInt32(userString);
Console.Write("Введите количество столбцов: ");
string userString1 = Console.ReadLine();
int b = Convert.ToInt32(userString1);
Console.Write("Введите диапазон чисел: от 1 до ");
string userString2 = Console.ReadLine();
int rand = Convert.ToInt32(userString2);
int[,] number = new int[a, b];
Console.WriteLine();
GetMatrix(number);
PrintArray(number);
NumberRowMinSumElements(number);



void NumberRowMinSumElements(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.WriteLine();
    Console.Write($"Наименьшая сумма элементов {minSum + 1} строка");
}

Console.WriteLine();
Console.WriteLine();