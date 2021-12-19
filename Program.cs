using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumberss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool flag;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) Console.WriteLine("{0} ", i);
            }
            Console.Read();
        }
    }
}