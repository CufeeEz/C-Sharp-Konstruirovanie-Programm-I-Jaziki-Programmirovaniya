namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввеите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввеите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввеите число C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a >= 2.0 && a <= 7.2)
            {
                a = 0;
            }
            else if (a >= -2.0 && a <= -0.5)
            {
                a = a * 2;
            }
            if (b >= 2.0 && b <= 7.2)
            {
                b = 0;
            }
            else if (b >= -2.0 && b <= -0.5)
            {
                b = b * 2;
            }
            if (c >= 2.0 && c <= 7.2)
            {
                c = 0;
            }
            else if (c >= -2.0 && c <= -0.5)
            {
                c = c * 2;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
