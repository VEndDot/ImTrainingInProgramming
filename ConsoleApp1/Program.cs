using System.Collections;
using System.Numerics;
using System.Text;
using System.Xml.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object aasd = 12;
            Console.WriteLine( Convert.ToString(aasd).GetType());
        }

        /// <summary>
        /// Калькулятор времени
        /// </summary>
        public static void TimeCalculator()
        {
            Console.Write("Введите минуты: ");
            int.TryParse(Console.ReadLine(), out int minutes);

            int totalHors = minutes / 60;
            int totalMin = minutes % 60;

            var declensionsForClocks = DeclinationForHours(totalHors);
            string declensionsForMinutes = DeclinationForMinutes(totalMin);

            // Я так понимаю, тут уже без условий не обойтись, чтобы сделать склонения

            Console.WriteLine($"Результат: {totalHors} {declensionsForClocks} {totalMin} {declensionsForMinutes}");
        }

        delegate string Declination();

        /// <summary>
        /// добавляет склонение для часов
        /// </summary>
        /// <param name="hor">Представляет час</param>
        /// <returns></returns>
        public static string DeclinationForHours(int hor)
        {
            if (hor == 0) return "часов";  // Опционально, для 0

            int lastDigit = hor % 10;
            int tens = hor % 100;

            if (tens >= 11 && tens <= 19) return "часов";
            if (lastDigit == 1) return "час";
            if (lastDigit >= 2 && lastDigit <= 4) return "часа";
            return "часов";
        }

        /// <summary>
        /// добавляет склонение для чисел
        /// </summary>
        /// <param name="min"></param>
        /// <returns></returns>
        public static string DeclinationForMinutes(int min)
        {
            if (min == 0) return "минут";
            int lastDigits = min % 10;
            int tens = min % 100;

            if (tens >= 11 && tens <= 19) return "минут";
            if (lastDigits == 1) return "минута";
            if (lastDigits >= 2 && lastDigits < 5) return "минуты";

            return "минута";
        }


    } 


}
