using System;

namespace TMS.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1:");
            Console.Write("Введите 1ое число: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2ое число: ");
            int b1 = int.Parse(Console.ReadLine());
            int result1 = 0;
            if (a1 > b1) result1 = a1 + b1;
            if (a1 == b1) result1 = a1 * b1;
            if (a1 < b1) result1 = a1 - b1;
            Console.Write(result1);

            //Задание 2
            Console.WriteLine("Задание 2:");
            Console.Write("Введите X: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            int y1 = int.Parse(Console.ReadLine());
            if (x1 > 0 && y1 > 0)
                Console.Write("Первая четверть");
            else if (x1 > 0 && y1 < 0)
                Console.Write("Вторая четверть");
            else if (x1 < 0 && y1 < 0)
                Console.WriteLine("Третья четверть");
            else if (x1 < 0 && y1 > 0)
                Console.WriteLine("Четвертая четверть");
            else
                Console.WriteLine("Центр окружности!");

            //Задание 3
            Console.WriteLine("Задание 3:");
            Console.Write("Введите 1ое число: ");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2ое число: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("Введите 3ье число: ");
            int c3 = int.Parse(Console.ReadLine());            
            if (a3<b3 && b3<c3 && a3<c3)
                Console.WriteLine($"{a3} -> {b3} -> {c3}");
            else if (a3 < b3 && b3 > c3 && a3<c3)
                Console.WriteLine($"{a3} -> {c3} -> {b3}");
            else if (a3 < b3 && b3 > c3 && a3>c3)
                Console.WriteLine($"{c3} -> {a3} -> {b3}");
            else if (a3 > b3 && b3 < c3 && a3<c3)
                Console.WriteLine($"{b3} -> {a3} -> {c3}");
            else if (a3 > b3 && b3 < c3 && a3>c3)
                Console.WriteLine($"{b3} -> {c3} -> {a3}");
            else if (a3 > b3 && b3 > c3 && a3>c3)
                Console.WriteLine($"{c3} -> {b3} -> {a3}");

            //Задание 4
            Console.WriteLine("Задание 4:");
            Console.Write("Введите A: ");
            double a4 = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            double b4 = double.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            double c4 = double.Parse(Console.ReadLine());
            if (Math.Pow(b4, 2) - 4 * a4 * c4 < 0 || a4 == 0)
                Console.WriteLine("Корней нет");
            else if (Math.Pow(b4, 2) - 4 * a4 * c4 == 0)
            {
                double x4 = -b4 / (2 * a4);
                Console.WriteLine("Корень один: x4");
            }
            else if (Math.Pow(b4, 2) - 4 * a4 * c4 > 0)
            {
                double x4_1 = Math.Round(-b4 - Math.Sqrt(Math.Pow(b4, 2) - 4 * a4 * c4) / (2 * a4), 3);
                double x4_2 = Math.Round(-b4 + Math.Sqrt(Math.Pow(b4, 2) - 4 * a4 * c4) / (2 * a4), 3);
                Console.WriteLine($"Корня два: {x4_1}, {x4_2}");
            }

            //Задание 5
            Console.WriteLine("Задание 5:");
            string string_number = Console.ReadLine();
            if (string_number.StartsWith('1'))
            {
                switch (string_number)
                {
                    case "10":
                        Console.WriteLine("десять");
                        break;
                    case "11":
                        Console.WriteLine("одинадцать");
                        break;
                    case "12":
                        Console.WriteLine("двенадцать");
                        break;
                    case "13":
                        Console.WriteLine("тринадцать");
                        break;
                    case "14":
                        Console.WriteLine("четыернадцать");
                        break;
                    case "15":
                        Console.WriteLine("пятнадцать");
                        break;
                    case "16":
                        Console.WriteLine("шестнадцать");
                        break;
                    case "17":
                        Console.WriteLine("семьнадцать");
                        break;
                    case "18":
                        Console.WriteLine("восемьнадцать");
                        break;
                    case "19":
                        Console.WriteLine("девятнадцать");
                        break;
                }
            }
            else
            {
                string text = "";
                switch (string_number[0])
                {
                    case '2':
                        text = "двадцать";
                        break;
                    case '3':
                        text = "тридцать";
                        break;
                    case '4':
                        text = "сорок";
                        break;
                    case '5':
                        text = "пятьдесят";
                        break;
                    case '6':
                        text = "шестьдесят";
                        break;
                    case '7':
                        text = "семьдесят";
                        break;
                    case '8':
                        text = "восемьдесят";
                        break;
                    case '9':
                        text = "девяносто";
                        break;
                }
                switch (string_number[1])
                {
                    case '1':
                        text += " один";
                        break;
                    case '2':
                        text += " два";
                        break;
                    case '3':
                        text += " три";
                        break;
                    case '4':
                        text += " четыре";
                        break;
                    case '5':
                        text += " пять";
                        break;
                    case '6':
                        text += " шесть";
                        break;
                    case '7':
                        text += " семь";
                        break;
                    case '8':
                        text += " восемь";
                        break;
                    case '9':
                        text += " девять";
                        break;
                }
                Console.WriteLine(text);
            }

            //Задание 6
            Console.WriteLine("Задание 6:");
            Console.Write("Введите сторону A: ");
            double a6 = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            double b6 = double.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            double c6 = double.Parse(Console.ReadLine());
            if (a6 >= b6 + c6 || b6 >= a6 + c6 || c6 >= a6 + b6)
                Console.WriteLine("Треугольника с такими сторонами не существует");
        }
    }
}
