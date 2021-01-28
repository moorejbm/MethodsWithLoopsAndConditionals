using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Console.WriteLine("***");
            PrintByThree();
            Console.WriteLine("***");
            Equal(2, 2);
            //Number(5);
        }



        // #1 Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
               
                Console.WriteLine(i);
            }
        }
        // #2  Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintByThree()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        // #3 Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void Equal(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Number is Equal");
            }
         else
            {
                Console.WriteLine("Number is Not Equal");
            }
        }
        // #4 Write a method to check whether a given number is even or odd.
       // public static void Number(int)



    }
}
    

