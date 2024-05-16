using System;

class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {(b == 0 ? 0 : a / b)}");
        }
    }
}