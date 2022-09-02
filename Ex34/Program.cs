// Массив случайных положительных трехзначных чисел. Подсчет количества четных чисел в массиве.
Console.WriteLine("Введите количество элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сейчас я заполню его случайными трехзачными положительными числами и посчитаю количество четных элементов массива ");

int[] array = new int[q];

int Method (int a)
{
        return array[a];
}
 
    Console.WriteLine("Ваш массив:");
    
for (int i = 0; i < q; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(" " + Method(i) + " ");
}
System.Console.WriteLine();

int quanIndPos = 0;

for(int j = 0; j < q; j++)
{
    if(array[j] % 2 == 0)
        {
            quanIndPos ++;
        } 
}
Console.WriteLine($"Количество четных элементов масcива = {quanIndPos}");


