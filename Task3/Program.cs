// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Задайте массив ");
string? Numbers = Console.ReadLine();

Numbers = Numbers + ",";
int[] NewArray(string NewNumbers)
{
    int[] array = new int[1];
    int j = 0;
    for (int i = 0; i < NewNumbers.Length; i++)
    {
        string NewNumbers1 = "";
        while (NewNumbers[i] != ',' && i < NewNumbers.Length)
        {
            NewNumbers1 += NewNumbers[i];
            i++;
        }
        array[j] = Convert.ToInt32(NewNumbers1);
        if (i < NewNumbers.Length - 1)
        {
            array = array.Concat(new int[] { 0 }).ToArray();
        }
        j++;
    }
    return array;
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array = NewArray(Numbers);

PrintArray(array);