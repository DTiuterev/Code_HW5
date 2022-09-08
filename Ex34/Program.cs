// Массив случайных положительных трехзначных чисел. Подсчет количества четных чисел в массиве.
Console.WriteLine("Введите количество элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сейчас я заполню его случайными трехзачными положительными числами и посчитаю количество четных чисел");

void QuanEvenNumbers()
{
int[] array = new int[q];    
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
int quanEvenNum = 0;
for(int j = 0; j < q; j++)
{
    if(array[j] % 2 == 0)
        {
            quanEvenNum ++;
        } 
}
Console.WriteLine($"Ваш массив: {String.Join(", ", array)}");
Console.WriteLine($"Количество четных чисел масcива = {quanEvenNum}");
}
QuanEvenNumbers();
