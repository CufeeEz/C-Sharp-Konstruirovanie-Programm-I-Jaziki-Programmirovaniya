namespace lab4_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double num = 1;

            Console.WriteLine("Каким циклом воспользоваться?\n1 - for\n2 - do while\n");
            int vibor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            if (vibor == 1)
            {
                for (int i = 1; i < n; i++)
                {
                    num = num / 2;
                    Console.WriteLine(num);
                }
            }


            int ii = 1;
            if (vibor == 2)
            {
                while (ii < n)
                {
                    num = num / 2;
                    Console.WriteLine(num);
                    ii++;
                }
            }
        }
    }
}
