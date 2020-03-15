using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static bool PrimeTest(int n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            int i = 5;

            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
                i = i + 6;

            }
            return true;
        }


        static void Main(string[] args)
        {

            int[] numberList = new int[100];

            for(int i = 0; i <100; i++)
            {
                numberList[i] = i;
            }

            foreach (int c in numberList)
            {
                if (PrimeTest(c) == true)
                {
                    
                            Console.WriteLine(c);
                    
                }
            }

            //Console.WriteLine(string.Join("\n", numberList));
            Console.ReadLine();
        }

        
    }
}
