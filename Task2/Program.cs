// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

int[] array = GetArray(length); 
string strArray = String.Join(" ",array);
WriteLine($"[{strArray}]");
int Number = SumNumber(array);
WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {Number}");


int SumNumber(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (i%2==1)
        {
            sum += Arr[i];
        }
    }
    return sum;
}

int[] GetArray(int size)
{
    int[] result = new int[size];

    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(-20, 20); // Для наглядности указал такой диапазон
    }
    return result;
}