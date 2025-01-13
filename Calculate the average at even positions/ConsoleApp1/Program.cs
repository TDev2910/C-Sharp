namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 1; test <= t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                if(n>0)
                {
                    int[] arr = new int[n];
                    for(int i = 0;  i<n; i++)
                    {
                        arr[i] = int.Parse(data[i]);
                    }
                    var result = Sum(arr);
                    Console.WriteLine($"Test {test} : \n {result}");
                }
                else
                {
                    Console.WriteLine($"Test {test} : \nN INVALID");
                }
            }
        }
        static double Sum(int[] arr)
        {
            int sum = 0; //Luu phan tu cac vi tri chan
            int numberofindex = 0; //Dem so luong phan tu o vi tri chan
            for (int i = 0; i < arr.Length; i+=2)
            {
                sum += arr[i];
                numberofindex++;
            }
            return sum * 1.0 / numberofindex;   
        }
    }
}
