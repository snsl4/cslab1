using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое число");
            string num1 = Console.ReadLine();
            Console.WriteLine("Второе число");
            string num2 = Console.ReadLine();
            multiplication(num1, num2);
            Console.ReadKey();
        }

        public static void multiplication(string num1, string num2)
        {
            Int64 multiplicand, multiplier, product = 0, startMultiplicand, startMultiplier;
            startMultiplicand = multiplicand = Int32.Parse(num1);
            startMultiplier = multiplier = Int32.Parse(num2);
            for (int i = 0; i < 32; ++i)
            {
                Console.WriteLine("Шаг " + (i + 1) + ":\n");

                Console.WriteLine("Умножаемое:\n" + FinishStringWithZeros(Convert.ToString(multiplicand, 2)) +
                    "\nУмножитель:\n" + FinishStringWithZeros(Convert.ToString(multiplier, 2)) + "\n");

                short lsb = (short)(multiplier & 1);

                if (lsb == 1)
                {
                    Console.WriteLine("Добавляем умножаемое и продукт\n");
                    product += multiplicand;
                }
                Console.WriteLine("Продукт:\n" + FinishStringWithZeros(Convert.ToString(product, 2)) + "\n");
                Console.WriteLine("Сдвиг умножаемого влево");
                Console.WriteLine("Сдвиг умножителя вправо");

                multiplicand <<= 1;
                multiplier >>= 1;
            }

            Console.WriteLine("\n" + Convert.ToString(startMultiplicand, 2) +
                "*" +
                Convert.ToString(startMultiplier, 2) +
                "=" +
                Convert.ToString(product, 2) + "\n");

            Console.WriteLine(startMultiplicand + " * " + startMultiplier + " = " + product);
        }

        static string FinishStringWithZeros(string val)
        {
            int count = 32 - val.Length;
            string head = "";
            for (int i = 0; i < count; ++i)
                head += "0";
            return head + val;
        }
    }
}
