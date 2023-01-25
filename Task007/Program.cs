// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = 0;
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

int[] arr = new int[8];
FillMas(arr);
PrintMas(arr);