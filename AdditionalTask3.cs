using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW_23_07
{
    internal class AdditionalTask3
    {
        unsafe static void Main()
        {
            string text = "Hello, World!";
            Console.WriteLine($"Initial text: {text}");

            char[] charArray = text.ToCharArray();
            fixed (char* p = charArray)
            {
                char* start = p;
                char* end = p + charArray.Length - 1;

                while (start < end)
                {
                    char temp = *start;
                    *start = *end;
                    *end = temp;

                    start++;
                    end--;
                }
            }

            string reversedText = new string(charArray);
            Console.WriteLine($"Reversed text: {reversedText}");
        }
    }
}
