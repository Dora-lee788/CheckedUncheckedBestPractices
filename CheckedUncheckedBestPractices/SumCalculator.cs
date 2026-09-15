using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUncheckedBestPractices
{
        static class SumCalculator
        {
            public static int SumChecked(int[] numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    try
                    {
                        sum = checked(sum + number);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Сумма превышает диапазон int — возвращаем int.MaxValue.");
                        return int.MaxValue;
                    }
                }
                return sum;
            }

            public static int ParseOrZero(string input)
                => int.TryParse(input, out int result) ? result : 0;
        }
    }
