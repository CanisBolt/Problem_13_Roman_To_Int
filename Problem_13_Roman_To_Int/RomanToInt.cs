using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13_Roman_To_Int
{
    class RomanToInt
    {
        /*
         *  Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
         *  Symbol       Value
         *  I            1
         *  V            5
         *  X            10
         *  L            50
         *  C            100
         *  D            500
         *  M            1000
         */
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Write the roman number:");
            string romanNumber = Console.ReadLine();

            for (int i = 0; i < romanNumber.Length; i++)
            {
                switch (romanNumber[i])
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        if (i > 0 && romanNumber[i - 1] == 'I')
                        {
                            result += 3;
                        }
                        else result += 5;
                        break;
                    case 'X':
                        if (i > 0 && romanNumber[i - 1] == 'I')
                        {
                            result += 8;
                        }
                        else result += 10;
                        break;
                    case 'L':
                        if (i > 0 && romanNumber[i - 1] == 'X')
                        {
                            result += 30;
                        }
                        else result += 50;
                        break;
                    case 'C':
                        if (i > 0 && romanNumber[i - 1] == 'X')
                        {
                            result += 80;
                        }
                        else result += 100;
                        break;
                    case 'D':
                        if (i > 0 && romanNumber[i - 1] == 'C')
                        {
                            result += 300;
                        }
                        else result += 500;
                        break;
                    case 'M':
                        if (i > 0 && romanNumber[i - 1] == 'C')
                        {
                            result += 800;
                        }
                        else result += 1000;
                        break;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
