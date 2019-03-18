using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            string s, path = "";
            bool isTrue;
            int numberOfText;
            Console.WriteLine("Номер текста:");
            do
            {
                numberOfText = int.Parse(Console.ReadLine());
                switch (numberOfText)
                {
                    case 1:
                        isTrue = true;
                        path = @"C:\lab\text1.txt";
                        break;
                    case 2:
                        isTrue = true;
                        path = @"C:\lab\text2.txt";
                        break;
                    case 3:
                        path = @"C:\lab\text3.txt";
                        isTrue = true;
                        break;
                    default:
                        isTrue = false;
                        break;
                }
                s = File.ReadAllText(path, Encoding.Default);

            }
            while (!isTrue);

            int[] count = new int[char.MaxValue];
            foreach (char t in s)
            {
                count[t]++;
            }

            double frequency, entropy = 0, information;
            for (int i = 0; i < char.MaxValue; i++)
            {
                if (count[i] > 0)
                {
                    frequency = (double)count[i] / s.Length;
                    entropy += frequency * Math.Log(1 / frequency, 2);
                    Console.WriteLine("{0} = {1}", (char)i, frequency);
                }
            }


            information = entropy * s.Length / 8.0;
            FileInfo file = new FileInfo(path);
            Console.WriteLine("Ентропия: {0} bit\nКоличество информации: {1} bytes", entropy, information);
            Console.ReadKey();
        }
    }
}
