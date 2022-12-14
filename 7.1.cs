namespace lab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine(); // Вводим строку
            str = str.Replace(" ", "").ToLower();
            string reverseStr = ""; // здесь будет наша перевернутая строка
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i]; // переворачиваем строку

            }
            if (str == reverseStr)
                Console.WriteLine("Введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();
        }
    }
}
