namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.234;
            int b = 1;
            double x = 3.413;
            double y = 1.789;
            double e = 2.71828;
            double z;
            z = (x + b) / (y + (b * b)) + (Math.Log(a) * (x + y)) / (Math.Pow(e, x) + y);
            Console.WriteLine($"Ответ: {z}");
        }
    }
}
