using System;
namespace InputTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ви ввели число {a}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Помилка введення!");
            }
        }
    }
}