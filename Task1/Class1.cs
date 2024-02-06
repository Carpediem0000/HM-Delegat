namespace Task1
{
    public delegate double Calculator(double x, double y);
    public class Calc
    {
        public static double Plus(double x, double y) => x + y;
        public static double Minus(double x, double y) => x - y;
        public static double Mult(double x, double y) => x * y;
        public static double Division(double x, double y) => x / y;

        public static double Calcu(double x, double y, Calculator meth)
        {
            if (y == 0 && meth == Division)
                return 0;

            return meth(x, y);
        }     
    }
}
