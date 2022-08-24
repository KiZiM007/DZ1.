// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size1)
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
int[] massiv = CreateArrayRndInt(size);

int EvenSum(int[] massiv1)
{
    int num = 0;
    int index = 0;
    for (int i = 0; i < massiv1.Length; i++)
    {
        if (index % 2 != 0) num = num + massiv1[i];
        index++;
    }
    return num;
}
int result = EvenSum(massiv);

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
