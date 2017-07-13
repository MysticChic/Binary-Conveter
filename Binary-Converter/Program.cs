using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the binary converter");
                Console.Write("Decimal: ");
                int decimalValue = int.Parse(Console.ReadLine());

                int remainder;
                string result = string.Empty;
                while (decimalValue > 0) // setting decimalValue greater then 0 
                {
                    remainder = decimalValue % 2; // takes first number divides it by 2nd number and gives us our remainder
                    decimalValue /= 2; // decimalValue = decimalValue / 2;
                    result = remainder.ToString() + result; // result += remainder.ToString();
                }
                Console.WriteLine("Binary: {0}", result); // what 0 is doing is taking the first thing it says inside the string and sets it to result
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sorry but please get your eyes checked because you obviously can't read when it says input decimal, good day!");
                Console.ReadLine();
            }
        }
    }
}
