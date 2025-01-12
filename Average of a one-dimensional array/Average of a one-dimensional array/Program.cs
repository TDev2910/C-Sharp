namespace Average_of_a_one_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());  
            for(int test = 1 ; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if (n > 0)
                {
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(data[i]);
                    }
                    var result = Sum(arr);
                    Console.WriteLine($"Test {test} \n {result * 1.0 /n }");
                }
                else
                {
                    Console.WriteLine($"Test {test} \nN INVALID");
                }
            }
        }
        static int Sum(int[] arr)
        {
            int sum = 0;    
            foreach(var item in arr)
            {
                sum += item;    
            }
            return sum;
        }
    }
}
