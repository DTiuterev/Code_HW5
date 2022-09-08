// Задайте одномерный массив случайных чисел. Найдите сумму элементов, стоящих на нечетных позициях.
Console.WriteLine("Введите количество элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

void SummOdd()
{
    int[] array = new int[q];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    int sumOdd = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(j % 2 > 0)
        {
            sumOdd += array[j];
        } 
    }
Console.WriteLine();
Console.WriteLine($"Ваш массив: {String.Join(", ", array)}");
Console.WriteLine($"Сумма элементов c нечетным индексом = {sumOdd}");
}
SummOdd();

