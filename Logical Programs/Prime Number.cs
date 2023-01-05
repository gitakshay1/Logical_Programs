using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime_Number
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Enter number");
            int Number=Convert.ToInt32(Console.ReadLine());
            int Num = 2;
            while(Number%Num!=0&&Num!=Number/2)
            {
                Num++;
            }
            if(Number%Num==0)
            {
                Console.WriteLine(Number + " is not Prime Number");
            }
            else
            {
                Console.WriteLine(Number+" is Prime Number");
            }
        }
    }
}
