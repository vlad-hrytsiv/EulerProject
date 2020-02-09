using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 3; i < userNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
