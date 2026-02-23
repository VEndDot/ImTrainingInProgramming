using System.Buffers.Text;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskSolution
{
    /// <summary>
    /// Решение задач. Все эти задачки чисто дурачество. Пытаюсь получше понять синтаксис C#.
    /// На данный момент, самая прикольная TextBasedBattleSimulator(); без ООП, функций и вообще все в одном цикле
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            //UserProfile();
            //SumTwoNumbers();
            //ConvertMetersToCentimeters();
            //CurrencyExchange();
            //TimeCalculator();
            //BodyMassIndex();
            //ElectronicWatches();
            //TheChangeCalculator();
            //AgeVerification();
            //CalculatorWithOperationSelection();
            //DeterminingTheTimeYear();
            //GuessNumber();
            //RockPaperScissors();
            //TheChineseZodiac();
            //ATMMachine();
            //ATMMachine2();
            //CalculateTimeWithDate();
            //TextBasedBattleSimulator();
            //MicrosoftLearnCodeProject_1();
            //MicrosoftLearnCodeProject_2();
            //MicrosoftLearnCodeProject_3();
            
        }
        /// <summary>
        /// код, который обрабатывает содержимое массива строк/ Делал просто по условию. Я бы по другому сделал
        /// Да и такие задачки не очень. За бабки да.
        /// </summary>
        public static void MicrosoftLearnCodeProject_3()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int periodLocation;

            foreach (string myString in myStrings)
            {
                string newStr = myString;

                while (true)
                {
                    periodLocation = newStr.IndexOf(".");

                    if (periodLocation == -1)
                    {
                        Console.WriteLine(newStr.TrimStart());
                        break;
                    }

                    Console.WriteLine(newStr.Substring(0, periodLocation).TrimStart());

                    newStr = newStr.Remove(0, periodLocation + 1);
                    Thread.Sleep(1000);
                }
            }

        }

        /// <summary>
        /// Код для проверки вводимых строк
        /// </summary>
        public static void MicrosoftLearnCodeProject_2()
        {
            string[] roles = { "administrator", "manager", "user" }; 

            Console.WriteLine($"Enter your role name (" +
                $"{char.ToUpper(roles[0][0]) + roles[0].Substring(1)}, " +
                $"{char.ToUpper(roles[1][0]) + roles[1].Substring(1)}, " +
                $"or {char.ToUpper(roles[2][0]) + roles[2].Substring(1)})");
            string message;
            do
            {
                var userInput = Console.ReadLine();

                if (!roles.Contains(userInput?.Trim().ToLower()))
                {
                    Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                    continue;
                }

                message = $"Your input value ({userInput}) has been accepted.";
                break;

            } while (true);
            
            Console.WriteLine(message);
        }

        /// <summary>
        /// Код для проверки целочисленного ввода
        /// </summary>
        public static void MicrosoftLearnCodeProject_1()
        {
            int user = 0;
            Console.Write("Enter an integer value between 5 and 10");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                    continue;
                }

                if (userInput < 5 || userInput > 10)
                {
                    Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
                    continue;
                }

                user = userInput;   
                break;
                
            }while (true);

            Console.WriteLine($"Your {user} input value  has been accepted.");

        }

        /// <summary>
        /// Простой скрипт игры
        /// </summary>
        public static void MicrosoftLearnBattle()
        {
            Random rand = new Random();

            int heroHP = 10;
            int heroHit = 0;

            int monsterHP = 10;
            int monsterHit = 0;

            do
            {
                heroHit = rand.Next(1, 11);

                monsterHP -= heroHit;
                Console.WriteLine($"Monster was damaged and lost {heroHit} health and now has {monsterHP} health.");

                if (monsterHP <= 0)
                {
                    Console.WriteLine("Hero wins!");
                    break;
                }

                monsterHit = rand.Next(1, 11);

                heroHP -= monsterHit;
                Console.WriteLine($"Hero was damaged and lost {monsterHit} health and now has {heroHP} health.");

                if (heroHP <= 0)
                {
                    Console.WriteLine("Monster wins!");
                    break;
                }
            } while (heroHP > 0 && monsterHP > 0);
        }

        /// <summary>
        /// Task #1 Анкета пользователя 
        /// </summary>
        public static void UserProfile()
        {
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");

            int.TryParse(Console.ReadLine(), out int age); // Не обращай на это внимание!
            Console.Write("Введите ваш город: ");
            var city = Console.ReadLine();

            Console.WriteLine($"Привет, {name}! Тебе {age} лет. Ты живешь в городе {city}.");
        }

        /// <summary>
        /// Task #2 Калькулятор суммы двух чисел
        /// </summary>
        public static void SumTwoNumbers()
        {
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int num_1);
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int num_2);
            int sum = num_1 + num_2;
            Console.WriteLine($"{num_1} + {num_2} = {sum}");
        }

        /// <summary>
        /// Task #3 Конвертер метров в сантиметры
        /// </summary>
        public static void ConvertMetersToCentimeters()
        {
            Console.Write("Введите длину в метрах: ");
            Decimal.TryParse(Console.ReadLine(), out decimal meter);// думаю decimal или double лучше тут подходят
            Console.WriteLine($"{meter} м = {meter * 100} см");
        }

        /// <summary>
        /// Обмен валюты
        /// </summary>
        public static void CurrencyExchange()
        {
            Console.Write("Сумма в рублях: ");
            decimal.TryParse(Console.ReadLine(), out decimal rub);
            Console.Write("Курс доллара: ");
            decimal.TryParse(Console.ReadLine(), out decimal rateDollar);

            // конвертация из рублей доллар
            int usd = (int)(rub / rateDollar);

            // вычисление курса евро
            decimal rateEur = rateDollar + (rateDollar * 0.1M);

            // конвертация из рублей в евро
            decimal eur = rub / rateEur;

            // остаток в рублях. Но он всегда тут будет пустым. Несовсем понял из чегого остаток считать то, доллары или евро...
            decimal balance = rub - usd * rateDollar;
            Console.WriteLine($"Результат:\nUSD: {usd:F2}\nEUR: {eur:F2}\nОстаток: {balance:F2} руб.");
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


            // Я понимаю, что для создания склонения мне нужно использовать условия, вынести в отдельные функции
            // Но логики моей не хватает
            // чтобы понять, как сделать склонение. У нейросети спросил, ее логику понял, но сам сделать не могу.

            Console.WriteLine($"Результат: {totalHors}  {totalMin}");
        }

        static string GetHoursWord(int hours)
        {
            if (hours % 10 == 1 && hours % 100 != 11) return "час";
            return "часов";
        }

        /// <summary>
        /// Индекс массы тела
        /// </summary>
        public static void BodyMassIndex()
        {
            Console.Write("Введите вес (кг): ");
            double.TryParse(Console.ReadLine(), out double weight);
            Console.Write("Введите рост (м): ");
            double.TryParse(Console.ReadLine(), out double height);
            double BMI = Math.Round(weight / Math.Pow(height, 2), 1);
            string result = "";

            if (BMI < 18.5)
            {
                result = "Недостаток веса";
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                result = "Норма";
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                result = "Избыток веса";
            }
            else
            {
                result = "Ожирение";
            }

            Console.WriteLine($"Ваш ИМТ: {BMI}\nКатегория: {result}");
        }

        /// <summary>
        /// Электронные часы
        /// </summary>
        public static void ElectronicWatches()
        {
            Console.Write("Прошло минут: ");
            int.TryParse(Console.ReadLine(), out int minutes);
            int totalHours = minutes / 60;
            int displayHours = totalHours % 24;
            int displayMinutes = displayHours % 60;
            Console.WriteLine($"Текущее время: {displayHours:D2}:{displayMinutes:D2}");
        }

        /// <summary>
        /// Калькулятор сдачи
        /// </summary>
        public static void TheChangeCalculator()
        {
            // Эта задача мне показалась куда проще чем калькулятор времени, где нужно было сделать склонение

            // Номиналы купюр
            int[] denominations = { 5000, 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.Write("Стоимость покупки: ");
            // Стоимость
            int.TryParse(Console.ReadLine(), out int cost);
            Console.Write("Внесено: ");
            // взнос
            int.TryParse(Console.ReadLine(), out int deposited);
            // Сдача
            int change = deposited - cost;

            Console.WriteLine($"Сдача: {change}");
            Console.WriteLine("Выдать: ");

            foreach (var denomination in denominations)
            {
                int numberOfBills = (change / denomination);
                if (numberOfBills != 0)
                {
                    Console.WriteLine($"- {denomination} руб: {numberOfBills} шт");
                    change = change % denomination;
                }
            }

            // Так я пытался понять логику задачи. Сначала решал так, потом уже через цикл сделал.
            //Console.WriteLine($"- 5000 руб: {change/5000} шт");
            //change = change % 5000;
            //Console.WriteLine($"- 1000 руб: {change/1000} шт");
            //change = change % 1000;
            //Console.WriteLine($"- 500 руб: {change/500} шт");
            //change = change % 500;
            //Console.WriteLine($"- 100 руб: {change / 100} шт");
            //change = change % 100;
            //Console.WriteLine($"- 50 руб: {change / 50} шт");
            //change = change % 50;
            //Console.WriteLine($"- 10 руб: {change / 10} шт");
            //change = change % 10;
            //Console.WriteLine($"- 5 руб: {change / 5} шт");
            //change = change % 5;
            //Console.WriteLine($"- 2 руб: {change / 2} шт");
            //change = change % 2;
            //Console.WriteLine($"- 1 руб: {change / 1} шт");
            //change = change % 1;
        }

        /// <summary>
        /// Проверка возраста
        /// </summary>
        public static void AgeVerification()
        {
            Console.Write("Ваш возраст: ");
            // возраст пользователя
            int.TryParse(Console.ReadLine(), out int userAge);

            if (userAge < 18)
            {
                Console.WriteLine($"Доступ запрещён! Приходи через {18 - userAge}-г.");
            }
            else if (userAge <= 60)
            {
                Console.WriteLine("Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Здравствуйте, уважаемый!");
            }
        }

        /// <summary>
        /// Калькулятор с выбором операции
        /// </summary>
        public static void CalculatorWithOperationSelection()
        {
            Console.Write("Введите первое число: ");
            double.TryParse(Console.ReadLine(), out double firstDigit);
            Console.Write("Введите второе число: ");
            double.TryParse(Console.ReadLine(), out double secondDigit);
            Console.Write("Выберите операцию (+, -, *, /): ");
            string? selectedOperation = Console.ReadLine();


            var result = selectedOperation switch
            {
                "/" => secondDigit != 0 ? (firstDigit / secondDigit) : Double.NaN,
                "+" => firstDigit + secondDigit,
                "-" => firstDigit - secondDigit,
                "*" => firstDigit * secondDigit,
                _ => Double.NaN,
            };

            if (Double.IsNaN(result))
            {
                Console.WriteLine("Ошибка в операции или делении на ноль");
                return;
            }

            Console.WriteLine($"Результат: {firstDigit} {selectedOperation} {secondDigit} = {result}");
        }

        /// <summary>
        /// Определение времени года
        /// </summary>
        public static void DeterminingTheTimeYear()
        {
            Console.Write("Введите номер месяца: ");
            string[] months = {
                    "",
                    "Январь",
                    "Февраль",
                    "Март",
                    "Апрель",
                    "Май",
                    "Июнь",
                    "Июль",
                    "Август",
                    "Сентябрь",
                    "Октябрь",
                    "Ноябрь",
                    "Декабрь",
                };



            if (!int.TryParse(Console.ReadLine(), out int userInput) || userInput < 1 || userInput > 12)
            {
                Console.WriteLine("Такого месяца нет!");
                return;
            }
            //for (int userInput = 1; userInput <= 12; userInput++)
            //{
            //    string timeYear = (userInput) switch
            //    {
            //        <= 2 => "Зима",
            //        < 6 => "Весна",
            //        < 9 => "Лето",
            //        < 12 => "Осень",
            //        12 => "Зима",
            //        _ => "Неправильно введенный месяц"
            //    };

            //    Console.WriteLine($"{months[userInput]} - это {timeYear}");
            //    Thread.Sleep(1000);
            //}

            string timeYear = (userInput) switch
            {
                <= 2 => "Зима",
                < 6 => "Весна",
                < 9 => "Лето",
                < 12 => "Осень",
                12 => "Зима",
                _ => "Неправильно введенный месяц"
            };

            Console.WriteLine($"{months[userInput]} - это {timeYear}");
        }

        /// <summary>
        ///  Отгадай число
        /// </summary>
        public static void GuessNumber()
        {
            Random rand = new Random();
            var secretNumber = rand.Next(1, 11);
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Отгадай число: ");
                int.TryParse(Console.ReadLine(), out int userInput);
                if (userInput == secretNumber)
                {
                    Console.WriteLine("Молодец! Успел среагировать)");
                    return;
                }
                else if (userInput < secretNumber)
                    Console.WriteLine("Промахнулся, бери выше!");
                else if (userInput > secretNumber)
                    Console.WriteLine("Ну не на столько же высоко!");
            }

            Console.WriteLine("Игры кончились! Битва идет не на жизнь, а на смерть");
        }

        /// <summary>
        /// Камень ножница бумага
        /// </summary>
        public static void RockPaperScissors()
        {
            // объект для генерации случайного числа
            Random rand = new Random();

            // массив элеметнов игры
            string[] rockPaperScissors = { "камень", "ножницы", "бумага" };

            // общение с пользователем
            Console.Write("Твой ход (камень, ножницы, бумага): ");

            // Выбор пользователя: камень, ножницы, бумага
            var userInput = Console.ReadLine()?.ToLower().Trim();

            // Проверяет элемент в массиве 
            var userChoice = Array.IndexOf(rockPaperScissors, userInput);

            // "исключение"
            if (userChoice == -1)
            {
                Console.WriteLine("Вы ввели недопустимое значение!");
                return;
            }

            // Мне показалось, что так проще всего сделать жульничество
            // Вообще способов много есть, как это сделать, но это самое простое как по мне.
            // Если бы была ничья, то пришлось мы может добавить условие, или вторую ветку переделать
            // Но я сделал уже так
            var aiChoice = rand.Next(100) <= 20 ? userChoice : rand.Next(0, 3);


            Console.WriteLine($"Компьютер выбрал: {rockPaperScissors[aiChoice]}");
            if (aiChoice == userChoice)
            {
                Console.WriteLine("Ничья, но ИИ победил");
            }
            else if ((userChoice == 0 && aiChoice == 1) || (userChoice == 1 && aiChoice == 2) || (userChoice == 2 && aiChoice == 0))
            {
                Console.WriteLine("Ты победил!");
            }
            else
            {
                Console.WriteLine("Победил ИИ");
            }

            /* 0 - камень; 1 - ножницы; 2 - бумага
             * 1) ничья, но выйграл ии |if (aiChoise == userChoise) => выйграл ии
                   U | AI   
                   0 | 0  
                   1 | 1
                   2 | 2
                
               2) выйграл пользователь | if ( (userChoise == 0) && (aiChoise == 1) || ( (userChoise == 1) && (aiChoise == 2) || ( (userChoise == 2) && (aiChoise == 0))
                   U | AI
                   0 | 1   - камень сломал ножницы, победа за пользователем
                   1 | 2   - ножницы режут бумагу, победа за пользователем
                   2 | 0   - бумага кроет камень, победа за пользователем 

               3) выйграл ИИ
                   U | AI
                   0 | 2   - бумага кроет камень, победа за ИИ
                   1 | 0   - камень ломает ножницы, победа за ИИ
                   2 | 1   - Ножницы режут бумагу, победа за ИИ

            (userChoise - aiChoise + 3) % 3; - эту формулу мне предложил ии. Я сам не могу ее вывести и поэтому решил через условия. 
            Даже когда просил разжевать мне ее, я все равно не понял до конца как она получается. Я знаю как ее применить
            Если 2 то победа пользователя если 1 то победа ИИ если 0 ничья и победа ИИ, но решал через условия, так-как это мое решение и
            я быстро понял как решить без математики, хоть выглядит ужасно.
            */
        }

        /// Китайский зодиак
        public static void TheChineseZodiac()
        {
            string[] chineseZodiac = {
                "Крыса",    // 0
                "Бык",      // 1  
                "Тигр",     // 2
                "Кролик",   // 3
                "Дракон",   // 4
                "Змея",     // 5
                "Лошадь",   // 6
                "Коза",     // 7
                "Обезьяна", // 8
                "Петух",    // 9
                "Собака",   // 10
                "Свинья"    // 11
            };
            Console.Write("Введите год рождения: ");
            int.TryParse(Console.ReadLine(), out int year);
            int yearNow = DateTime.Now.Year;



            if (year < 1900) Console.WriteLine("Слишком далёкое прошлое, я такое не знаю");
            else if (year <= yearNow) Console.WriteLine($"{year} год - это год {chineseZodiac[(year - 1900) % 12]}");
            else Console.WriteLine($"{year} год еще не наступил, но это будет год {chineseZodiac[(year - 1900) % 12]}");
        }

        /// <summary>
        /// Банкомат
        /// </summary>
        public static void ATMMachine()
        {
            // список всех доступных банкнот
            int[] banknotes = { 5000, 2000, 1000, 500, 100 };

            // банкомат содержит по 3 банкноты каждого номинала
            //Dictionary<int, int> banknotes = new() 
            //{ 
            //    [5000] = 3,
            //    [2000] = 3,
            //    [1000] = 3,
            //    [500] = 3,
            //    [100] = 3,
            //};


            Console.Write("Сумма для снятия: ");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 100)
            {
                Console.WriteLine("Банкомат не может выдать сумму меньше 100 рублей ");
                return;
            }
            //if (userInput < 100 || userInput%100 != 0)
            //{
            //    Console.WriteLine("Банкомат не может выдать сумму меньше 100 рублей или сумму, которая не делится на 100");
            //    return;
            //} Я решил не добавлять это условие, так-как задача без него получается интереснее. Оставил лишь, что нельзя меньше сотки снять

            foreach (var banknote in banknotes)
            {
                // Если введенная сумма меньше банкноты, то пропускаем банкноту
                if (userInput < banknote)
                {
                    continue;
                }

                Console.WriteLine($"- {banknote}: {userInput / banknote} шт");

                // вычитаем количество банкнот из запроса пользователя, и сохраняем остаток в переменной
                userInput -= (userInput / banknote) * banknote;

                // выходим из цикла, если больше нельзя снять денег
                if (userInput == 0)
                {
                    break;
                }

            }
            Console.WriteLine($"Остаток на счете: {userInput}");
        }

        /// <summary>
        /// Решил с количеством купюр поиграться здесь, но получилось что-то странное, но вроде работает
        /// </summary>
        public static void ATMMachine2()
        {
            int moneyATM = 0;
            Console.Write($"Сумма для снятия: ");
            int.TryParse(Console.ReadLine(), out int userInput);


            Dictionary<int, int> banknotes = new()
            {
                [5000] = 3,
                [2000] = 3,
                [1000] = 3,
                [500] = 3,
                [100] = 3,
            };

            foreach (var banknote in banknotes)
            {
                moneyATM += banknote.Value * banknote.Key;
            }

            Console.WriteLine($"В банкомате сейчас доступно для снятия {moneyATM}");
            if (userInput > moneyATM)
            {
                Console.WriteLine($"Вы не можете снять денег больше, чем есть в банкомате: {moneyATM}!");
                return;
            }

            foreach (var key in banknotes.Keys.ToList())
            {
                int countBancnones = banknotes[key];

                for (int i = 0; i < countBancnones; i++)
                {
                    if ((userInput - key) < 0)
                    {
                        break;
                    }
                    else
                    {
                        userInput -= key;
                        banknotes[key] -= 1;
                    }
                }
                if (countBancnones - banknotes[key] != 0)
                {
                    Console.WriteLine($"- {key}: {countBancnones - banknotes[key]} шт");
                }
            }

            Console.WriteLine($"Осталось на счете, купюр не хватило: {userInput}");
        }

        /// <summary>
        /// Непонравилась мне эта задача, решил оставить так
        /// </summary>
        public static void CalculateTimeWithDate()
        {
            try
            {
                Console.Write("Введите первую дату(день месяц): ");
                int[] dateOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                Console.Write("Введите вторую дату (день месяц): ");
                int[] dateTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var firstDate = new DateTime(DateTime.Now.Year, dateOne[1], dateOne[0]);
                var secondDate = new DateTime(DateTime.Now.Year, dateTwo[1], dateTwo[0]);

                if (firstDate > secondDate)
                {
                    Console.WriteLine($"Вторая дата раньше\nМежду ними {(firstDate - secondDate).Days} дней");
                }
                else if (firstDate < secondDate)
                {
                    Console.WriteLine($"Первая дата раньше\nМежду ними {(secondDate - firstDate).Days} дней");

                }
                else
                {
                    Console.WriteLine("Даты равны");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Некорректная дата! Проверьте день и месяц.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
        }

        /// <summary>
        /// Симулятор боя. Вот такие задачи нам нравятся. Хотя прошлые тоже нужны мне были. каеф! 
        /// </summary>
        public static void TextBasedBattleSimulator()
        {
            string[] moveOperation = { "(атака)", "(лечение)", "(защита)" };

            Random rand = new Random();
            // Генерируем HP пользователя
            int userHp = rand.Next(80, 121);
            // Генерируем HP ИИ
            int enemyHp = rand.Next(80, 121);

            // счетчик ходов
            int counterOfMoves = 0;

            // защита у пользователя и врага
            bool userDef = false;
            bool enemyDef = false;
            // для статистики
            int hitEnemy = 0;
            int hitUser = 0;
            while (userHp > 0 && enemyHp > 0)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                counterOfMoves++;
                Console.WriteLine($"=================== Текущий ход: {counterOfMoves} ===================");
                

                Console.WriteLine($"Твои HP: {userHp} (-{hitEnemy}) Твоя защита: {userDef}\nВраг HP: {enemyHp} (-{hitUser}) Враг защита: {enemyDef}");
                Console.ForegroundColor = ConsoleColor.White;

                // урон пользователя в текущем ходе
                int uAttackPower = rand.Next(10, 31);
                // шанс крита пользователя в текущем ходе
                int uChanceCriticalHit = rand.Next(1, 101);

                // урон ИИ в текущем ходе
                int eAttackPower = rand.Next(10, 31);
                // шанс крита ИИ в текущем ходе
                int eChanceCriticalHit = rand.Next(1, 101);

                // ход пользователя
                Console.Write("Выбери ход: 1 (атака), 2 (лечение), 3 (защита): ");
                int.TryParse(Console.ReadLine(), out int userAction);
                Console.WriteLine($"Твой ход: {userAction} {moveOperation[userAction - 1]}");


                // Ход врага: атака, лечение, защита
                int enemyAction = rand.Next(1, 101);
                
                // пользователь атакует
                if (userAction == 1)
                {
                    // сообщение для статистики
                    string messageDef = "";
                    // итоговый нанесенный удар
                    int hit = 0;
                    Console.WriteLine("- Игрок атакует");
                    // случайная вариация урона
                    int randomDamageVariation = rand.Next(-5, 6);
                    // Если сработал крит
                    int doubleDamage = uChanceCriticalHit <= 20 ? 2 : 1;
                    // проверяем защиту врага | если защита стоит
                    if (enemyDef)
                    {
                        hit = ((uAttackPower + randomDamageVariation) * doubleDamage) / 2;
                        // выполняет атаку с 50% уроном
                        enemyHp -= hit;
                        // синимает защиту
                        enemyDef = false;
                        messageDef = $"У врага сработала защита. Весь урон уменьшен на 2. | {(uAttackPower + randomDamageVariation) * doubleDamage} = {hit}";
                    }
                    // если защиты нет
                    else
                    {
                        hit = (uAttackPower + randomDamageVariation) * doubleDamage;
                        enemyHp -= hit;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        $"==== Информация об атаке ИГРОКА ===" +
                        $"\n- двойной урон ({doubleDamage});" +
                        $"\n- случайна вариация урона ({randomDamageVariation});" +
                        $"\n- Сила атаки({uAttackPower})" +
                        $"\n- Нанесенный урон по врагу ({hit})" +
                        $"\n- {messageDef}");
                    Console.ForegroundColor = ConsoleColor.White;
                    hitUser = hit;
                }
                // враг сбрасывает лечение, если атакует
                else if (userAction == 2 && enemyAction <= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("- Лечение прервалось");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // Если враг не атакует, то игрок может лечиться
                else if (userAction == 2 && !(enemyAction <= 60))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    // случайное значение лечения
                    int healing = rand.Next(15, 26);
                    // здоровье пользователя без проверки
                    int newUserHp = userHp + healing;
                    // Если здоровье пользователя со случайным значением больше 120, то оставляем 120
                    userHp = newUserHp >= 120 ? 120 : newUserHp;
                    Console.WriteLine($"- Пользователь лечится: +{healing}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // каст защиты на игрока
                else if (userAction == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("- Игрок в защите");
                    userDef = true;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // враг атакует
                if (enemyAction <= 60)
                {
                    // сообщение для статистики
                    string messageDef = "";
                    // итоговый нанесенный удар
                    int hit = 0;
                    Console.WriteLine("- Враг атакует");
                    // случайная вариация урона
                    int randomDamageVariation = rand.Next(-5, 6);
                    // Если сработал крит
                    int doubleDamage = eChanceCriticalHit <= 20 ? 2 : 1;
                    // проверяет защиту игрока | если защита есть
                    if (userDef)
                    {

                        // выполняет атаку с 50% уроном
                        hit = ((eAttackPower + randomDamageVariation) * doubleDamage)/2;
                        userHp -= hit;
                        // снимает защиту
                        userDef = false;
                        messageDef = $"У пользователя сработала защита. Весь урон уменьшен на 2. | {(eAttackPower + randomDamageVariation) * doubleDamage} = {hit}";
                    }
                    // если защиты нет
                    else
                    {
                        hit = (eAttackPower + randomDamageVariation) * doubleDamage;
                        userHp -= hit;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        $"==== Информация об атаке ВРАГА ===" +
                        $"\n- двойной урон ({doubleDamage});" +
                        $"\n- случайна вариация урона ({randomDamageVariation});" +
                        $"\n- Сила атаки({eAttackPower})" +
                        $"\n- Нанесенный урон по игроку({hit})" +
                        $"\n- {messageDef}");
                    Console.ForegroundColor = ConsoleColor.White;
                    hitEnemy = hit;
                }
                // враг лечится
                else if (enemyAction <= 80)
                {
                    Console.ForegroundColor= ConsoleColor.Magenta;
                    // случайное значение лечения
                    int healing = rand.Next(15, 26);
                    // здоровье врага без проверки
                    int newEnemyHp = enemyHp + healing;
                    // Если здоровье врага со случайным значением больше 120, то оставляем 120
                    enemyHp = newEnemyHp >= 120 ? 120 : newEnemyHp;
                    Console.WriteLine($"- Враг лечится: +{healing}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // враг кастует защиту на себя
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("- Враг в защите");
                    enemyDef = true;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                //Console.ReadLine();
                //Console.Clear();
            }
            Console.Clear();

            if (userHp > enemyHp)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Победил игрок");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Победил ИИ");
            }
        }
    }
}
