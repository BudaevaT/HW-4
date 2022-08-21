Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int number = a;

for (int i = 1; i < b; i++)
{
    number = number * a;
}

Console.WriteLine($"A в степени B равно {number}.");
