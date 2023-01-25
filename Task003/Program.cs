// Возведите число в натуральную степень В используя цикл
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B (натуральная степень): ");
int B = int.Parse(Console.ReadLine() ?? "0");
int number = A;
for (int i=2; i<=B; i++)
{
    number = number * A;
}
Console.Write("Число " + A + " в степени " + B + " = ");
Console.Write(number);