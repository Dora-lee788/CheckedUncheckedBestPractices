using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUncheckedBestPractices
{
 class Program
        {
            static void Main()
            {
                Console.WriteLine("SumChecked([1, 2, 3]) = " + SumCalculator.SumChecked(new[] { 1, 2, 3 }));
                Console.WriteLine("SumChecked([int.MaxValue, 1]) = " + SumCalculator.SumChecked(new[] { int.MaxValue, 1 }));

                Console.WriteLine("ParseOrZero_Bad(\"42\") = " + SumCalculator.ParseOrZero_Bad("42"));
                Console.WriteLine("ParseOrZero_Good(\"42\") = " + SumCalculator.ParseOrZero_Good("42"));
                Console.WriteLine("ParseOrZero_Good(\"abc\") = " + SumCalculator.ParseOrZero_Good("abc"));

                Console.ReadKey();
            }
        }
    }

