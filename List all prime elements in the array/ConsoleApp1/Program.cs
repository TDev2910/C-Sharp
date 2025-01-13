namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if(n>0)
                {
                    int[] arr = new int[n]; 
                    for(int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(data[i]);    
                    }
                    Console.Write($"Test {test} : \n");
                    Solve(arr);
                }
                else
                {
                    Console.WriteLine($"Test {test} : \nN INVALID");
                }
            }
        }

        static void Solve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(IsPrimeNumber(arr[i]))
                {
                    Console.WriteLine($"({i} , {arr[i]})");
                }
            }
        }
        static bool IsPrimeNumber(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int bound = (int)Math.Sqrt(n);
            for (int i = 2; i <= bound; i++)
            {
                if(n % i ==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
