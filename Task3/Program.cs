// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

double[] array = GetArray(length); 
string strArray = String.Join(" ",array);
WriteLine($"[{strArray}]");
double Max = MaxNumber(array);
WriteLine ($"Максимальный элемент массива: {Max}");
double Min = MinNumber(array);
WriteLine ($"Минимальный элемент массива: {Min}");
WriteLine ($"Разница: {Max-Min}");

double MaxNumber(double[] ArrayM)
{
    double max = ArrayM[0];
    for(int i=1; i<ArrayM.Length; i++)
    {
        if (ArrayM[i]>max)
        {
            max=ArrayM[i];
        }
    }
    return max;
}

double MinNumber(double[] ArrayMin)
{
    double min = ArrayMin[0];
    for(int i=1; i<ArrayMin.Length; i++)
    {
        if (ArrayMin[i]<min)
        {
            min=ArrayMin[i];
        }
    }
    return min;
}


double[] GetArray(int size)
{
    double[] result = new double[size];

    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}