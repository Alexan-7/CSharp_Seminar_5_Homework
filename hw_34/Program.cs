// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Write("Предложите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);

// Задаём массив, заполненный случайными положительными трёхзначными числами
int[] array = new int[count];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

Console.WriteLine($"[{string.Join(", ", array)}]");

// ПОКАЖЕМ ТЕПЕРЬ КОЛИЧЕСТВО ЧЁТНЫХ ЧИСЕЛ В МАССИВЕ
int EvenCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        EvenCount++;
    }
}
Console.WriteLine($"Количество четных элементов в массиве {EvenCount}");
Console.WriteLine();