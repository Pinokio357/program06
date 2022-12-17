using System;

bool control = true;
int GetNumber(string message)
{
    int result = 0;
    while (control)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            control = false;
        else
            Console.WriteLine("enter correct number");
    }

    return result;
}




int n = GetNumber("enter number of elements");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{

    a[i] = GetNumber("enter number");
}
int count = 0;
for (int i = 0; i < n; i++)
{

    Console.Write($"{a[i]}, ");
    if (a[i] < 0)
    {
        count += 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"negativ count: {count}");