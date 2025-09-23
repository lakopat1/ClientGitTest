using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            int count = 0;
            //
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
                count++;
            }

            Console.WriteLine( count );

            //тест нашего феч
        }
    }
}
