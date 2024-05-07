using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        Console.Write($"The last digit of {number} is ");
        bool negative = false;
        if (number < 0)
        {
            negative = true;
        }
        int last_digit = (Math.Abs(number)) % 10;
        if (negative)
        {
            last_digit = last_digit * -1;
        }
        if (last_digit > 5)
        {
            Console.WriteLine($"{last_digit} and is greater than 5");
        }
        else if (last_digit == 0)
        {
            Console.WriteLine($"{last_digit} and is 0");
        }
        else
        {
            Console.WriteLine($"{last_digit} and is less than 6 and not 0");
        }
    }
}