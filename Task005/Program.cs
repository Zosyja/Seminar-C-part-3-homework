// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result = 1;
while (i <= number)
{
    result = result * i;
    i++;
}
Console.Write("Произведение чисел от 1 до " + number + " = ");
Console.Write(result);