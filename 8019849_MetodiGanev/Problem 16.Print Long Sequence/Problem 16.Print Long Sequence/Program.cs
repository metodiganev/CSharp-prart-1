using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Print_Long_Sequence
{
    class printLongSequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).
    {
        static void Main()
        {
            int printEnd = 1000;
            for (int counter = 2; counter <= printEnd; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine((counter * -1));
                }
            }
        }
    }
}
