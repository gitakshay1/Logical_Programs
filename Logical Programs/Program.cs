namespace Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To choose respective Program\n1 Fibonacci Series" +
                "\n2 Perfect Number \n3 Prime Number");
            int Choise=Convert.ToInt32(Console.ReadLine());
            switch(Choise)
            {
                case 1:
                    Fibonacci_Series fibonacci_Series=new Fibonacci_Series();
                    fibonacci_Series.Fibo_Series();
                    break;
                case 2:
                    Perfect_Number perfect_Number=new Perfect_Number();
                    perfect_Number.PerfectNumber();
                    break;
                case 3:
                    Prime_Number prime_Number=new Prime_Number();
                    prime_Number.PrimeNumber();
                    break;
                default:
                    Console.WriteLine("Enter valid choise");
                    break;
            }
        }
    }
}
