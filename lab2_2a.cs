using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DivMod(0b110010, 0b1010);

            Console.ReadKey();
        }

        public static void DivMod(Int32 dividend, Int32 divisor)
        {
            int d = dividend;
            int r = divisor;

            while (r < dividend)
            {
                r <<= 1;
            }
            Console.WriteLine(dividend + " / " + divisor);
            Console.WriteLine(Convert.ToString(Convert.ToInt32(dividend), 2) + " / " + Convert.ToString(Convert.ToInt32(divisor), 2) + "\n");
            Console.WriteLine("Делимое  " + Convert.ToString(Convert.ToInt32(d), 2));
            Console.WriteLine("Делитель   " + Convert.ToString(Convert.ToInt32(r), 2) + "\n");
            string result = string.Empty;
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine("Шаг " + (i+1));
                if (d < divisor && r < divisor)
                {
                    break;
                }
                if (r > d)
                {
                    r >>= 1;
                    Console.WriteLine("Сдвиг");
                    result += "0";
                }
                else
                {
                    d -= r;
                    Console.WriteLine("Делимое - делитель");
                    result += "1";
                    r >>= 1;
                }
                Console.WriteLine("Делимое  " + Convert.ToString(Convert.ToInt32(d), 2));
                Console.WriteLine("Делитель   " + Convert.ToString(Convert.ToInt32(r), 2));
                Console.WriteLine("Результат = " + result + "\n");

            }
            Console.WriteLine("Результат : " + Convert.ToInt32(result, 2) + " ( " + result + " ) " + "   остаток : " + d + " ( " + Convert.ToString(Convert.ToInt32(d), 2) + " ) ");

        }
    }
}