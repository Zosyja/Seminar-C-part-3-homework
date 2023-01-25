// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(3);
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
int Sum(int[] arr)
{
    int result = 0;
    int i = 1;
    while(i <= arr.Length)
    {
        result = result + arr[i];
        i = i + 2;
    }
    return result;
}

int[] arr = new int[10];
FillMas(arr);
PrintMas(arr);
Console.Write("Сумма чисел массива стоящих на нечетной позиции: ");
Console.WriteLine(Sum(arr));