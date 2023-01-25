// Показать кубы чисел, заканчивающихся на четную цифру

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(99);
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

void CubeOfEven(int[] arr)
{
    for(int i = 0; i <arr.Length; i++)
    {
        if (arr[i]%2==0) arr[i]=arr[i]*arr[i]*arr[i];
        else arr[i] = 0;
    }
}

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
CubeOfEven(arr);
PrintMas(arr);