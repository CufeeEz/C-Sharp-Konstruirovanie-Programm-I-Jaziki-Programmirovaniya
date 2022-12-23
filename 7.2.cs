using System.Text;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listglasnih = new List<char> { 'a', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            int q = -1;
            Console.WriteLine("Введите ваше ФИО");
            string FIO = Console.ReadLine();
            string FIOLower = FIO.ToLower();
            string s = FIOLower;
            StringBuilder s1 = new StringBuilder(FIO);
            StringBuilder s2 = new StringBuilder(FIO);
            Console.WriteLine("Длинна строки = " + FIO.Length + " символов");
            for (int i = 0; i < FIO.Length; i++)
            {
                if (FIOLower[i] == FIOLower[1])
                {
                    q += 1;
                }
                if (i % 2 == 0)
                {
                    s1.Insert(i + 1, "-");
                }
            }
            q = 0;

            for (int i = 0; i < FIO.Length; i++)
            {

                if (FIO[i] == ' ')
                {
                    q += 1;
                }
                if (q > 1)
                {
                    if (listglasnih.Contains(FIO[i]))
                    {
                        FIO = FIO.Remove(i, 1);
                    }
                }
            }
            for (int i = 0; i < FIOLower.Length*2; i++)
            {
                if (i % 2 != 0)
                {
                    s = s.Insert(i, "-");
                }
            }
            Console.WriteLine("Количество букв, совпадающих со второй буквой фамилии " + "(" + FIOLower[1] + ")" + " = " + q);
            Console.WriteLine(s);
        }
    }
}
