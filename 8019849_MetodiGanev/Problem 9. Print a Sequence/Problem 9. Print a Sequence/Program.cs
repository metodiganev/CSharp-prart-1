using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Print_a_Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
{
    class Print_a_Sequence
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = -3;
            int number3 = 4;
            int number4 = -5;
            int number5 = 6;
            int number6 = -7;
            int number7 = 8;
            int number8 = -9;
            int number9 = 10;
            int number10 = -11;
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", number1, number2, number3, number4,
                number5, number6, number7, number8, number9, number10);
        }
    }
}
