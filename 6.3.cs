namespace lab6_32
{
    class program
    {
        static void Main(string[] args)
        {
            string[][] a = new string[5][];
            a[0] = new string[] { "З", "а", "щ", "и", "т", "а", " ", "к", "о", "м", "п", "ь", "ю", "т", "е", "р", "н", "о", "й", " ", "и", "н", "ф", "о", "р", "м", "а", "ц", "и", "и" };
            a[1] = new string[] { "Б", "а", "з", "ы", " ", "д", "а", "н", "н", "ы", "х", " ", "и", " ", "с", "и", "с", "т", "е", "м", "ы", " ", "у", "п", "р", "а", "в", "л", "е", "н", "и", "я", " ", "б", "а", "з", "а", "м", "и", " ", "д", "а", "н", "н", "ы", "х" };
            a[2] = new string[] { "К", "о", "н", "с", "т", "р", "у", "и", "р", "о", "в", "а", "н", "и", "е", " ", "п", "р", "о", "г", "р", "а", "м", "м", " ", "и", " ", "я", "з", "ы", "к", "и", " ", "п", "р", "о", "г", "р", "а", "м", "м", "и", "р", "о", "в", "а", "н", "и", "я" };
            a[3] = new string[] { "П", "р", "о", "г", "р", "а", "м", "м", "н", "ы", "е", " ", "с", "р", "е", "д", "с", "т", "в", "а", " ", "с", "о", "з", "д", "а", "н", "и", "я", " ", "I", "n", "t", "e", "r", "n", "e", "t", " ", "п", "р", "и", "л", "о", "ж", "е", "н", "и", "й" };
            a[4] = new string[] { "Т", "е", "х", "н", "о", "л", "о", "г", "и", "я", " ", "р", "а", "з", "р", "а", "б", "о", "т", "к", "и", " ", "п", "р", "о", "г", "р", "а", "м", "м", "о", "г", "о", " ", "о", "б", "е", "с", "п", "е", "ч", "е", "н", "и", "я" };
            foreach (string[] strarr in a)
            {
                foreach (string str in strarr)
                    Console.Write(str);
                Console.WriteLine("");
            }
        }
    }
}