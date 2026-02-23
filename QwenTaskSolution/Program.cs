namespace QwenTaskSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeCalculator();
        }


        /// <summary>
        /// QWEN Task #1 Калькулятор возраста
        /// </summary>
        public static void AgeCalculator()
        {
            Console.Write("Как ваше имя: ");
            var userName = Console.ReadLine();
            
            Console.Write("В каком году вы родились: ");
            if (!int.TryParse(Console.ReadLine(), out int birthYear) || birthYear > DateTime.Now.Year)
            {
                Console.WriteLine("Ошибка: Введите корректный год рождения!");
                return;
            }

            // расчет возраста пользователя
            int userAge = DateTime.Now.Year - birthYear;

            if (userAge < 0 || userAge > 120)
            {
                Console.WriteLine("Похоже, вы ошиблись с годом рожденя");
                return;
            }

            string ageCategory = userAge switch
            {
               <= 2 => "младенец",
               <= 12 => "ребенок",
               <= 17 => "подросток",
               <= 60 => "взрослый",
                _ => "мудрый наставник",
            };
            Console.WriteLine($"Возрастная группа: {ageCategory}");
            Console.Write("Какой ваш любимый цвет: ");
            var favoriteColor = Console.ReadLine().ToLower();

            if (favoriteColor == "синий" || favoriteColor == "голубой") favoriteColor += " 🌊 Классика!";
            

            // вывод сообщения пользователю
            Console.WriteLine($"Привет, {userName}! Тебе примерно {userAge} лет. Круто, что ты любишь цвет {favoriteColor}");
        }
    }
}
