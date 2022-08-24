// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());


double[] CreateArrayRndDouble(int size1, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}
double[] massiv = CreateArrayRndDouble(size, 1, 100);

double MinMax(double[] massiv1)
{
    double min = massiv1[0];
    double max = massiv1[0]; ;
    for (int i = 0; i < massiv1.Length; i++)
    {
        if (massiv1[i] < min) min = massiv1[i];
        else if (massiv1[i] > max) max = massiv1[i];
    }
    return max - min;
}
double result = MinMax(massiv);

void Print(double[] end)
{
    Console.Write("[");
    for (int i = 0; i < end.Length; i++)
    {
        if (i < end.Length - 1) Console.Write($"{Math.Round(end[i], 2, MidpointRounding.ToZero)}. "); //Math.Round - округляет число. MidpointRounding.ToZero - чтобы отображался 0
        else Console.Write($"{Math.Round(end[i], 2, MidpointRounding.ToZero)}");
    }
    Console.Write("]");
}
Print(massiv);
Console.Write($" => {Math.Round(result, 2, MidpointRounding.ToZero)}. ");