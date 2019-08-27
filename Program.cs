using System;
using System.Collections;

namespace softserve_c__fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] normalizer(int[] num)
            {
                int div = num[1] / num[2];
                num[0] += div;
                num[1] -= div * num[2];
                                
                int divider = num[2];
                
                while ( divider > 0 )
                {
                    if ( num[2] % divider == 0 && num[1] % divider == 0 )
                    {
                        System.Console.WriteLine($"Divider is { divider }");
                        num[1] /= divider;
                        num[2] /= divider;
                        divider = 0;
                    }
                    else
                    {
                        divider--;
                        System.Console.Write($"{ divider + 1 } : ");
                    }
                }
                return num;
            }

            string sign (int[] num)
            {
                int count = 0;

                for (int i = num.Length - 1; i >= 0; i--)
                {
                    if (num[i] < 0)
                    {
                        //num[i] *= -1;
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    return "";
                }
                return "-";
            }

            void output(int[] num)
            {
                if (num.Length == 3)
                {
                    System.Console.WriteLine("Format: full(optional) enumenator/denumerator");
                    System.Console.Write(sign(num));
                    if (num[0] != 0)
                    {
                        System.Console.Write($"{ Math.Abs(num[0]) } and ");
                    }
                    if (num[1] != 0)
                    {
                        System.Console.WriteLine($"{ Math.Abs(num[1]) }/{ Math.Abs(num[2]) }");
                    }
                    else
                    {
                        System.Console.WriteLine("0");
                    }                    
                }
                else
                {
                    System.Console.WriteLine("Not 3!");
                }
            }

            int[] number = new int[] { 3, -292, -282 };
            int[] number_abs = new int[] { Math.Abs(number[0]), Math.Abs(number[1]), Math.Abs(number[2])};

            output(number);
            output(normalizer(number_abs));
        }
    }
}
