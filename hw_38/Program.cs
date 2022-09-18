// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76

Console.Write("Предложите количество элементов в массиве: ");
//int count = int.Parse(Console.ReadLine()!);
double[] array = new double[int.Parse(Console.ReadLine()!)];

for (int i = 0; i < array.Length; i++) // Задаём массив, заполненный случайными вещественными числами числами
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 3, MidpointRounding.AwayFromZero);
    // Nextdouble() дает случайное вещественное число в диапазоне от 0 до 1, поэтому добавляем * 100
}

double MaxEl = array[0]; // Ты присваивал значения до их появления, по этому там были нули сразу
double MinEl = array[0]; // Теперь присваиваются правильно

// Найдем максимальный и минимальный элемент массива (семинары по блок-схемам)
foreach (var value in array)
{
    if (value < MinEl) MinEl = value;

    if (value > MaxEl) MaxEl = value;
}

Console.WriteLine($"[{string.Join(" | ", array)}]"); // другой разделитель, т.к. запятых и так много
Console.WriteLine($"Максимальный элемент в массиве - это {MaxEl}");
Console.WriteLine($"Минимальный элемент в массиве - это {MinEl}");

// Найдем разницу между максимальным и минимальным элементами
Console.WriteLine($"Разница между этими элементами {MaxEl} - {MinEl} = {(MaxEl - MinEl):F1}");

/* Набрал для пробы из книги Флёнова "Библия C#"
int [] array = { 10, 20, 4, 10, 44, 95, 74, 28, 84, 79 };

int max = array[0];
int min = array[0];

foreach (var value in array)
{
    if (value < min)
        min = value;
    if (value > max)
        max = value;
}
Console.WriteLine($"[{string.Join(", ", array)}], min = {min}, max = {max}");
*/