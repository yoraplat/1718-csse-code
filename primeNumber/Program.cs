using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            bool  isPrime = true;


            if (input > 100){
                Console.WriteLine("Input must be 100 or lower");
            } else {
                for (int i = 1; i <= input; i++){
                    for (int j = 2; j <= input; j++){
                        if (i != j && i % j == 0){
                            isPrime = false;
                        }
                    }

                    if (isPrime){
                        Console.WriteLine(i + " is prime");
                    }
                    isPrime = true;
                }
            }


        }
    }
}
