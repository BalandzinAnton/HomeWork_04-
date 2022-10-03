// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

int[] array = GetArray(length); 
string strArray = String.Join(" ",array);
WriteLine($"[{strArray}]");
EvenNumber(array);
int Number = EvenNumber(array);
WriteLine($"Колличество четных элементов в массиве равно: {Number}");


int EvenNumber(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i]%2==0)
        {
            sum+=1;
        }
    }
    return sum;
}

int[] GetArray(int size)
{
    int[] result = new int[size];

    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}