// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size1)
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int[] massiv = CreateArrayRndInt(size);

int EvenNumbers(int[] massiv1)
{
    int num = 0;
    for (int i = 0; i < massiv1.Length; i++)
    {
        if (massiv[i] % 2 == 0) num++;
    }
    return num;
}
int result = EvenNumbers(massiv);

void Print(int[] end)
{
    Console.Write("[");
    for (int i = 0; i < end.Length; i++)
    {
        if (i < end.Length - 1) Console.Write($"{end[i]}, ");
        else Console.Write($"{end[i]}");
    }
    Console.Write("]");
}
Print(massiv);
Console.Write($" => {result}");