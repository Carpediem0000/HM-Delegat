using Task1;
using Task2;
namespace HM_Delegat
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Task 1*/

            Calculator calc = Calc.Plus;
            double res = calc(5, 10);
            Console.WriteLine(res);
            calc = Calc.Minus;
            res = calc(5, 10);
            Console.WriteLine(res);
            calc = Calc.Mult;
            res = calc(5, 10);
            Console.WriteLine(res);
            calc = Calc.Division;
            res = calc(5, 10);
            Console.WriteLine(res);

            /*Task 2*/

            User user = new(
                    "Alex",
                    23,
                    178,
                    76,
                    "user 2001",
                    "123456789"
                );
            Console.WriteLine(user);
        }
    }
}
