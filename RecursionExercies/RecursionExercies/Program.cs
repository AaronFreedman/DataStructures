using System;

namespace RecursionExercies
{
    class Program
    {

        static int Factorial(int start)
        {
            //base/escape case
            if(start <= 1)
            {
                return 1;
            }
            
            return start * Factorial(start - 1);
        }

        static int Fibb(int index)
        {
            //base/escape case
            if (index <= 1)
            {
                return 0;
            }
            if (index == 2)
            {
                return 1;
            }

            return Fibb(index - 1) + Fibb(index - 2);
        }

        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
