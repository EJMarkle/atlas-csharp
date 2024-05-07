using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char alph = 'a';
            while (alph <= 'z')
            {
                Console.Write(alph);
                alph++;
            }
        }
    }
}