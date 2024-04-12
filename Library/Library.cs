namespace MyLibrary
{
    public class Library
    {
        public static double AreaCalculation(double r)
        {
            return Math.PI * r * r;
        }
        public static double AreaCalculation(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static bool CheckingSquareness(double a, double b, double c)
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;
        }
    }
}
