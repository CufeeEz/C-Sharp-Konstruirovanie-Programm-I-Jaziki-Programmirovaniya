using System.Collections.Generic;
using System;

namespace lab5_1
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество купюр: ");
            int kup = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номинал купюр: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            Money one = new Money(kup, nam);
            int n = 0;
            while(n == n)
            {
                Console.WriteLine("\nКакое действие вы хотите выполнить?\n1 - вывести номинал и количество купюр\n2 - определить, хватит ли денежных средств на покупку товара на сумму N рублей.\n3 - определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства. ");
                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor == 1)
                {
                    one.output();
                }
                if (vibor == 2)
                {
                    one.buy();
                }
            }
        }
    }
    class Money
    {
        int first;
        int second;
        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public void output()
        {
            Console.WriteLine($"\nКоличество купюр: {first}\nНоминал купюр: {second}");
        }
        public void buy()
        {
            Console.WriteLine("\nВведите стоимость товара: ");
            int prise = Convert.ToInt32(Console.ReadLine());
            int aww = (first * second) / prise;
            if (aww >= 1)
            {
                Console.WriteLine($"На сумму {first*second} можно купить {aww} товара");
            }
            if (aww < 0 )
            {
                Console.WriteLine($"Ваших средств не хватает на покупку даже 1 еденицы товара\n");
            }
         }

    }
}
