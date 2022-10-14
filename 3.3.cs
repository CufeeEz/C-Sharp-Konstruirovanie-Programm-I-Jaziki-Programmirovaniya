namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число R: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double k = Math.Pow(5 * R + 2, 2) % 4;
            Console.WriteLine(k);
            double u;
            switch (k)
            {
                case 0:
                    u = Math.Tan(R) + Math.Sin(Math.Pow(R, 3));
                    Console.WriteLine($"Результат: {u}"); break;

                case 1:
                    u = Math.Pow(R, 2) + Math.Pow(R + 1, 1 / 5);
                    Console.WriteLine($"Результат: {u}"); break;
                case 2 | 3:
                    u = Math.Pow(Math.E, R) + 2.5 * (R - 3);
                    Console.WriteLine($"Результат: {u}"); break;
            } 
        }
    }
}
