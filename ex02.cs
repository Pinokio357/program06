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
int b1 = GetNumber("enter b1:");
int k1 = GetNumber("enter k1:");
int b2 = GetNumber("enter b2:");
int k2 = GetNumber("enter k2:");
double x = (b2 - b1)/(k1- k2);
double y = k1 * x + b1;
Console.WriteLine($"({x}, {y})");


