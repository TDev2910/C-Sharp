using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}");
                if(n<=0)
                {
                    Console.WriteLine("No Result");
                }
                else
                {
                    for(int j = 0 ; j <= n; j++)
                    {
                        if(j % 2 == 0)
                        {
                            Console.WriteLine(j+ " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
