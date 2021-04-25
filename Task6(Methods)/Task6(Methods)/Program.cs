using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterName(out string name1, out string name2, out double word1, out double word2, out bool result);
            EnterAge(out int age1, out int age2, out result);
            bool anotherNum = true;
            Calculate(ref name1, name2, age1, age2, anotherNum);
            Console.ReadKey();
        }

        static void EnterName(out string name1, out string name2, out double word1, out double word2, out bool result)
        {
            Console.Write("Введите имя первого человека:\t");
            do
            {
                name1 = Console.ReadLine();
                bool result1 = Double.TryParse(name1, out word1);
                if (result1 == false)
                {
                    Console.Write("Введите имя второго человека:\t");
                    result = true;

                }
                else
                {
                    Console.Write("Имя человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
            do
            {
                name2 = Console.ReadLine();
                bool result2 = double.TryParse(name2, out word2);
                if (result2 == false)
                {
                    Console.Write("Введите возраст первого человека:\t");
                    result = true;
                }
                else
                {
                    Console.Write("Имя человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
        }
        
        static void EnterAge(out int age1, out int age2, out bool result)
        {
            age1 = Convert.ToInt32(null);
            do
            {
                try
                {
                    age1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите возраст второго человека:\t");
                    result = true;
                }

                catch
                {
                    Console.Write("Возраст человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }

            while (result == false);
            age2 = Convert.ToInt32(null);
            do
            {
                try
                {
                    age2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Возраст человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
        }

        static void Calculate(ref string name1, string name2, int age1, int age2, bool anotherNum)
        {
            Console.WriteLine($"А человек с каким именем старше? (Если {name1} нажмите 1, если {name2} 2)");
            anotherNum = true;
            do
            {
                string comp = Console.ReadLine();
                switch (comp)
                {
                    case "1":

                        if (age1 > age2)
                        {
                            Console.WriteLine($"Правильно {name1} старше {name2} на {age1 - age2} лет");
                        }
                        else if (age1 == age2)
                        {
                            Console.WriteLine($"Не правильно {name1} и {name2} ровесники");
                        }
                        else if (age1 < age2)
                        {
                            Console.WriteLine($"Не правильно, {name2} старше {name1} на {age2 - age1} лет");
                        }
                        anotherNum = true;
                        break;

                    case "2":
                        if (age2 > age1)
                        {
                            Console.WriteLine($"Правильно {name2} старше {name1} на {age2 - age1} лет");
                        }
                        else if (age2 == age1)
                        {
                            Console.WriteLine($"Не правильно {name2} и {name1} ровесники");
                        }
                        else if (age2 < age1)
                        {
                            Console.WriteLine($"Не правильно, {name1} старше {name2} на {age1 - age2} лет");
                        }
                        anotherNum = true;
                        break;

                    default:
                        Console.WriteLine("Ответ не корректен, попробуйте ещё раз");
                        anotherNum = false;
                        break;
                }
            }
            while (anotherNum == false);
        }
    }
}
