using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace pitbull305dale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Write("*");
                }
            WriteLine();
            }
             
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j == i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadKey();
        }
            
    }
}
