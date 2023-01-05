using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci_Series
    {
        public void Fibo_Series()
        {
            int NextNum = 0;
            Console.WriteLine("Enter First term of series");
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second term of series");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter How many terms have to add in series");
            int Terms=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series is \n{0} \n{1}",Num1,Num2);
            for(int Term=1; Term<=Terms; Term++)
            {
                NextNum = Num1 + Num2;
                Console.WriteLine(NextNum);
                Num1 = Num2;
                Num2 = NextNum;
            }
        }
    }
}
