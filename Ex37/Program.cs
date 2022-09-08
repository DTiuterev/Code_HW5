// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
Console.WriteLine("Задайте произвольный массив, указав количество элементов и вводя последовательно элементы массива");
Console.WriteLine("Я найду произведение пар элеметов массива (первый и последний, второй и предпоследний и т.д.)");
Console.WriteLine("Чтобы получились пары элементов, количество элементов массива должно быть четным");
Console.Write("Ведите количество элементов массива:\t");
int quanElements = int.Parse(Console.ReadLine());
if (quanElements % 2 == 0)
{
int[] array = new int[quanElements];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());   
}
Console.WriteLine($"Ваш массив: {String.Join(", ", array)}");

int multiplay2Numbers = 0;
Console.Write("Произведение противоположных элементов массива = ");
for (int i = 0; i < array.Length/2; i++)
{
    multiplay2Numbers = array[i]*array[array.Length - 1 - i];
    Console.Write($"{multiplay2Numbers} ");
}
}
else
{
    Console.WriteLine("Вы ввели нечетное количество элементов массива, я не смогу разбить их на пары");
    Console.WriteLine("Введите четное количество элементов массива");
}

