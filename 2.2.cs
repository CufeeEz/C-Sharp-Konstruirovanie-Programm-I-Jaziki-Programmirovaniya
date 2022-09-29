namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.97;
            double y = -0.0024;
            double J;
            double e = 2.71828;
            double p;
            J = Math.Pow(e, (4 * x / 5) + 2 * Math.Sin(7 * Math.Log(x + (5 / 3))));
            p = J;
            x = -0.5;
            Console.WriteLine($"J1 = {J}");
            J = Math.Pow(e, (4 * x / 5) + 2 * Math.Sin(7 * Math.Log(x + (5 / 3))-p));
            Console.WriteLine($"J2 = {J}");
        }
    }
}
