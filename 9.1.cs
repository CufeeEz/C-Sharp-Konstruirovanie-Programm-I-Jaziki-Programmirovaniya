using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    struct MARSH
    {

        public string nachalniy_punkt_marshryta;
        public string konechniy_punkt_marshryta;
        public int nomer_marshryta;
        public override string ToString()
        {
            return (string.Format(@"Начальный пункт назначения: {0} Конечный пункт назначения: {1} Номер маршрута: {2}", nachalniy_punkt_marshryta, konechniy_punkt_marshryta, nomer_marshryta));
        }



        class Program
        {

            static void Main(string[] args)
            {
                int n = 8;
                MARSH[] mas = new MARSH[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Начальный пункт маршрута:");
                    mas[i].nachalniy_punkt_marshryta = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Конечный пункт маршрута:");
                    mas[i].konechniy_punkt_marshryta = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Номер маршрута:");
                    mas[i].nomer_marshryta = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Информация в базе:");
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                    Console.WriteLine(mas[i]);

                Console.WriteLine("Введите номер маршрута для вывода информации: ");
                int fam = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (mas[i].nomer_marshryta == fam) Console.WriteLine(mas[i]); k++;
                }

                if (k == 0) Console.WriteLine("Маршрут отсутствует!");
                Console.ReadKey(true);
            }

        }
    }
}
