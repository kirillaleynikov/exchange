using System;
namespace exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tryParseResult = false;
            var value = 0.00d;
            var kurs = 60.47d;
            var com037 = 0.37d;
            var com500 = 500d;

            while (!tryParseResult)
            {
                Console.Write("Введите значение в долларах: ");
                var userInput = Console.ReadLine();
                tryParseResult = double.TryParse(userInput, out value);
            }

            if (value <= com500 / kurs)
            {
                Console.WriteLine("Курс доллара: " + kurs + " ₽");
                Console.WriteLine("Вы выводите: {0:#.##} ₽", (kurs * value));
                Console.WriteLine("Комиссия банка составляет 8 ₽");
                Console.WriteLine("Итого: {0:#.##} ₽", (value * kurs - 8));
            }
            else
            {
                Console.WriteLine("Курс доллара: " + kurs + " ₽");
                Console.WriteLine("Вы выводите: {0:#.##} ₽", (value * kurs));
                Console.WriteLine("Комиссия банка составляет: " + com037 + " %");
                Console.WriteLine("Итого: {0:#.##} ₽", (value * kurs * 0.9963));
            }
        }
    }
}