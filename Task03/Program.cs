// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 21);
}

void ReversArray(int[] array, int count)
{
    if (count == 0) return;
    Console.Write($"{array[count - 1]} ");
    ReversArray(array, count - 1);
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Перевернутый массив: [");
ReversArray(array, array.Length);
Console.Write("]");