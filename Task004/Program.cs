// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for (int i=number; number!=0; number=number/10)
{
    int last = number%10;
    sum = sum + last;
}
Console.Write("Сумма цифр в числе = ");
Console.WriteLine(sum);