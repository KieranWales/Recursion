 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Factory!");
            Console.Write("Please enter a number: ");

            int n = int.Parse(Console.ReadLine());
            int nFact = Recursive(n);
            Console.WriteLine($"{n}! is {nFact}");
            Console.ReadLine();
        }

        static int Factorial(int num)
        {
            int answer = 1;
            for (int i = num; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
        }

        static int Recursive(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return  n * Recursive(n - 1);
        }
    }
}
