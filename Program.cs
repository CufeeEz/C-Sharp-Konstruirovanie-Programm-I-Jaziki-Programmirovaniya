namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите номер студента: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Каким методом вы хотите запустить программу? \n1 - через IF\n2 - через CASE\n");
            int vibor = Convert.ToInt32(Console.ReadLine());

            if (vibor == 1)
            {
                if (num == 1)
                {
                    Console.WriteLine("Яковлева Кристина Савельевна");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Спиридонова Варвара Ивановна");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Смирнов Никита Давидович");
                }
                else if (num == 4)
                {
                    Console.WriteLine("Иванов Матвей Арсентьевич");
                }
                else if (num == 5)
                {
                    Console.WriteLine("Галкин Сергей Степанович");
                }
                else if (num == 6)
                {
                    Console.WriteLine("Тарасов Иван Романович");
                }
                else if (num == 7)
                {
                    Console.WriteLine("Воронина Злата Ильинична");
                }
                else if (num == 8)
                {
                    Console.WriteLine("Боброва Арина Львовна");
                }
                else if (num == 9)
                {
                    Console.WriteLine("Зайцев Максим Артёмович");
                }
                else if (num == 10)
                {
                    Console.WriteLine("Волков Григорий Иванович");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                }
            }
            if (vibor == 2)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Яковлева Кристина Савельевна"); break;
                    case 2:
                        Console.WriteLine("Спиридонова Варвара Ивановна"); break;
                    case 3:
                        Console.WriteLine("Смирнов Никита Давидович"); break;
                    case 4:
                        Console.WriteLine("Иванов Матвей Арсентьевич"); break;
                    case 5:
                        Console.WriteLine("Галкин Сергей Степанович"); break;
                    case 6:
                        Console.WriteLine("Тарасов Иван Романович"); break;
                    case 7:
                        Console.WriteLine("Воронина Злата Ильинична"); break;
                    case 8:
                        Console.WriteLine("Боброва Арина Львовна"); break;
                    case 9:
                        Console.WriteLine("Зайцев Максим Артёмович"); break;
                    case 10:
                        Console.WriteLine("Волков Григорий Иванович"); break;
                    default: Console.WriteLine("Вы ввели неверное значение!"); break;
                }
            }
            if (vibor > 2 && vibor < 1)
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }
        }
    }
}
