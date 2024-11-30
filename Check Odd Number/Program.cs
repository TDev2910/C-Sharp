using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i <= t;i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                Console.WriteLine($"Test {i}");
                if(n<=0 || k > n)
                {
                    Console.WriteLine("No Result");
                }
                else
                {
                    for(int j = k ; j <= n; j++)
                    {
                        if(j % 2 !=0)
                        {
                            Console.WriteLine(j + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
