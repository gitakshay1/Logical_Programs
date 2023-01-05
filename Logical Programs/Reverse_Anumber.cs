using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Anumber
    {
        public void Reverse_Number()
        {
            Console.WriteLine("Enter Number");
            int Num=Convert.ToInt32(Console.ReadLine());
            int RevNum = 0 ,Temp=0;
            while(Num%10!=0&&Num/10!=0)
            {
                Temp = Num % 10;
                RevNum += Temp;
                Num = Num / 10;
                RevNum= RevNum*10;
            }
            RevNum = RevNum + Num;
            Console.WriteLine("Reverse Number is" + RevNum);
        }
    }
}
