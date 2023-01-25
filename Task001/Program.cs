// Найти кубы чисел от 1 до N
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i < number+1; i++)
{
    Console.Write(i + ": ");
    int cube = i*i*i;
    Console.WriteLine(cube);
}