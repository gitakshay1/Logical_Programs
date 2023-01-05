using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Perfect_Number
    {
        public void PerfectNumber()
        {
            Console.WriteLine("Enter Number");
            int Number=Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for(int i=1; i<=Number/2;i++)
            {
                if(Number%i==0)
                {
                    Sum += i;
                }
            }
            if(Sum == Number)
            {
                Console.WriteLine(Number + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(Number + " is not Perfect Number");
            }

        }
    }
}
