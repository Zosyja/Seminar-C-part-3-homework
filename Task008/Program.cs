// Определить, присутствует ли в заданном массиве, некоторое число

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(-10, 11);
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

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[k];

FillMas(arr);
PrintMas(arr);

Console.Write("Введите искомое число: ");
int x = int.Parse(Console.ReadLine() ?? "0");

int FindNumber(int[] arr)
{
    int result = 0;
    for(int i = 0; i <arr.Length; i++)
    {
        if (arr[i]==x) result=result+1;
    }
    return result;
}
Console.Write("Число " + x + " повторяется: ");
Console.Write(FindNumber(arr));