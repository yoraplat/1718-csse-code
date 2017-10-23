using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int [] arr = new int[input];
            arr[0] = 0;
            arr[1] = 1;
            Console.WriteLine((arr[0] + arr[1]));
            
            // Fibonacci

            for (int i = 2; i <= input ;i++){
                int nextInt = (arr[i -2] + arr[i -1]);

                arr[i] = nextInt;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
