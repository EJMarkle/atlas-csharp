using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char alph = 'a';
            while (alph <= 'z')
            {
                if (alph == 'q' || alph == 'e')
                {
                    alph++;
                    continue;
                }
                Console.Write(alph);
                alph++;
            }
        }
    }
}