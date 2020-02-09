using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            long reachNumber = 4000000;
            long currentNumber = 0;

            long firstNumber = 0;
            long secondNumber = 1;

            long sum = 0;

            while (currentNumber <= reachNumber)
            {
                if (currentNumber%2 == 0)
                {
                    sum += currentNumber;
                }
                currentNumber = firstNumber + secondNumber;

                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
