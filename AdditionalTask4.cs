using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW_23_07
{
    internal class AdditionalTask4
    {
        unsafe static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: a = {a}, b = {b}");

            int* pA = &a;
            int* pB = &b;

            *pA = *pA + *pB;
            *pB = *pA - *pB;
            *pA = *pA - *pB;

            Console.WriteLine($"After: a = {a}, b = {b}");
        }

    }
}
