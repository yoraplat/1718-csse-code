using System;

namespace primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number?");
            var num1 = Convert.ToInt32(Console.ReadLine());

            

        bool isPrime(int number){
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i){
                if (number % i == 0) return false;
            }
            return true;
        }

            for (int j = 0; j <= num1; j++){
                if (isPrime(j)){
                    Console.WriteLine( j + " is een priemgetal");
                } else {
                    Console.WriteLine(j + " is geen priemgetal");
                }
            }
        }
    }
}
