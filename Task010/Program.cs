// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(1000);
        arr[i] = num;
    }
}
int FindCount(int[] arr)
{
    int result = 0;
    for(int i = 0; i <arr.Length; i++)
    {
        if (arr[i]<=99 && arr[i]>=10) result++;
    }
    return result;
}

int[] arr = new int[123];
FillMas(arr);
Console.Write("Количество элементов из отрезка [10,99]: ");
Console.WriteLine(FindCount(arr));