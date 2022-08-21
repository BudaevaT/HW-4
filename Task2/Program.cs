// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = n; i > 0; i = i / 10)
{
    sum = sum + i % 10;
}
Console.WriteLine($"Сумма цифр равна {sum}");