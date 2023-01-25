// Написать сумму чисел от 1 до A
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
int number = 1;
while(number<=A)
{
    sum = sum + number;
    number++;
}
Console.Write("Сумма чисел от 1 до " + A + " = ");
Console.Write(sum);