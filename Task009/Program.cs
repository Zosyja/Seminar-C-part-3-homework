// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(100, 1000);
        arr[i] = num;
    }
}
void PrintMas(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
int Even(int[] arr)
{
    int even = 0;
    for(int i = 0; i <arr.Length; i++)
    {
        if (arr[i]%2==0) even++;
    }
    return even;
}
int Odd(int[] arr)
{
    int odd = 0;
    for(int i = 0; i <arr.Length; i++)
    {
        if (arr[i]%2>0) odd++;
    }
    return odd;
}

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);

Console.Write("Четных чисел: ");
Console.WriteLine(Even(arr));
Console.Write("Нечетных чисел: ");
Console.WriteLine(Odd(arr));