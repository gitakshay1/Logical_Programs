namespace Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To choose respective Program\n1 Fibonacci Series");
            int Choise=Convert.ToInt32(Console.ReadLine());
            switch(Choise)
            {
                case 1:
                    Fibonacci_Series fibonacci_Series=new Fibonacci_Series();
                    fibonacci_Series.Fibo_Series();
                    break;
                default:
                    Console.WriteLine("Enter valid choise");
                    break;
            }
        }
    }
}
