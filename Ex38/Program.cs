//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
Console.WriteLine("Задайте произвольный массив, указав количество элементов и вводя последовательно элементы массива");
Console.Write("Ведите количество элементов массива:\t");

void DiffMaxMin()
{
int elementsCount = int.Parse(Console.ReadLine());
double[] array = new double[elementsCount];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:\t");
    array[i] = double.Parse(Console.ReadLine());   
}
Console.WriteLine($"Ваш массив: {String.Join(", ", array)}");

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }   
    }
double diffMaxMin = max - min;
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diffMaxMin}");
}
DiffMaxMin();