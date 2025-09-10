using System;

class Program
{
    static double memory = 0;

    static double GetNumber()
    {
        Console.Write("Введите число: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    static double GetFirstNumber()
    {
        Console.Write("Введите первое число: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    static double GetSecondNumber()
    {
        Console.Write("Введите второе число: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    static void Main()
    {
        double n1, n2, result = 0;
        bool working = true;

        while (working)
        {
            Console.WriteLine("\nВыберите действие: + - * / % 1/x x^2 x^1/2 M+ M- MR C");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    n1 = GetFirstNumber();
                    n2 = GetSecondNumber();
                    result = n1 + n2;
                    break;

                case "-":
                    n1 = GetFirstNumber();
                    n2 = GetSecondNumber();
                    result = n1 - n2;
                    break;

                case "*":
                    n1 = GetFirstNumber();
                    n2 = GetSecondNumber();
                    result = n1 * n2;
                    break;

                case "/":
                    n1 = GetFirstNumber();
                    n2 = GetSecondNumber();
                    if (n2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        continue;
                    }
                    result = n1 / n2;
                    break;

                case "%":
                    n1 = GetFirstNumber();
                    n2 = GetSecondNumber();
                    if (n2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        continue;
                    }
                    result = n1 % n2;
                    break;

                case "1/x":
                    n1 = GetNumber();
                    if (n1 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        continue;
                    }
                    result = 1 / n1;
                    break;

                case "x^2":
                    n1 = GetNumber();
                    result = n1 * n1;
                    break;

                case "x^1/2":
                    n1 = GetNumber();
                    if (n1 < 0)
                    {
                        Console.WriteLine("Ошибка: нельзя извлечь корень из отрицательного числа!");
                        continue;
                    }
                    result = Math.Sqrt(n1);
                    break;

                case "M+":
                    n1 = GetNumber();
                    memory += n1;
                    Console.WriteLine("Значение добавлено в память: " + memory);
                    continue;

                case "M-":
                    n1 = GetNumber();
                    memory -= n1;
                    Console.WriteLine("Значение вычтено из памяти: " + memory);
                    continue;

                case "MR":
                    result = memory;
                    Console.WriteLine("Извлечено из памяти: " + memory);
                    break;

                case "C":
                    memory = 0;
                    result = 0;
                    Console.WriteLine("Память очищена");
                    continue;

                default:
                    Console.WriteLine("Неизвестная операция!");
                    continue;
            }

            Console.WriteLine("Результат: " + result);
            
            Console.WriteLine("Продолжить? (y/n)");
            if (Console.ReadLine().ToLower() != "y")
            {
                working = false;
            }
        }

        Console.WriteLine("Калькулятор закрыт. Итог в памяти: " + memory);
    }
}