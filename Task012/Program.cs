// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(10);
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
void MultiMass(int[] arr)
{
    int i = 0;
    while (i < arr.Length/2)
    {
        arr[i] = arr[i] * arr[arr.Length-1-i];
        arr[arr.Length-1-i] = 0;
        i++;
    }
}

int[] arr = new int[10];
FillMas(arr);
PrintMas(arr);
MultiMass(arr);

for (int el = 0; el < arr.Length/2; el++)
{
    Console.Write(arr[el] + " ");
}