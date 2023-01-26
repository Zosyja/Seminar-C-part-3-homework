// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillMas(double [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
}
void PrintMas(double [] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
double[] arr = new double[10];
FillMas(arr);
PrintMas(arr);

double max = arr[0];
double min = arr[0];

for (int el = 1; el <= arr.Length-1; el++)
{
    if (arr[el]>max) max = arr[el];
    if (arr[el]<min) min = arr[el];
}

double result = max-min;
Console.WriteLine("Максимальное значение = " + max);
Console.WriteLine("Минимальное значение = " + min);
Console.WriteLine("Разница между максимальным и минимальным значениями = " + result);