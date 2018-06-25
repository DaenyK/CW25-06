using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cw();
            // task1();
            // task2();
            //  task4();
            // task5();
            //task6();
            //  task8();
            //     task11();
            //task15();
            //task16();
            //task31();
            //task34();
            task37();
        }
        static void cw()
        {
            Console.WriteLine("hello world");
            Console.Write("введите имя: ");

            //string s = "привет, " +str;
            //Console.WriteLine(s);

            string str = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("привет, " + str);
        }
        static void task1()
        {
            string str = "";
            int i = 0;
            do
            {
                str += Console.ReadLine();
                i++;
                // Console.Clear();
            } while (!str.Contains('.'));//(str!=".");

            int countSpace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                    b++;
            }

            Console.WriteLine("кол-во символов: " + i);
            Console.WriteLine("кол-во пробелов: " + b);
            Console.WriteLine("кол-во пробелов: " + countSpace);

        }
        static void task2()
        {
            string ticket = Console.ReadLine();
            if (ticket.Length == 6)
            {
                //сумм первых трех цифр
                int sum1 = ticket[0] + ticket[1] + ticket[2];
                int sum2 = ticket[3] + ticket[4] + ticket[5];

                if (sum1 == sum2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("билет счастливый");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("билет не счастливый");
                }
            }
        }
        static void task4()
        {
            Console.Write("введите цифру A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("введите цифру B: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("а равно b, либо меньше b");
        }
        static void task5()
        {
            Console.Write("введите любую цифру: ");
            string a = Console.ReadLine();
            if (Int32.Parse(a) > 0)
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            else Console.WriteLine("ваше число меньше или равно нулю");
        }
        static void task6()
        {
            string str;

            Random rnd = new Random();
            str = rnd.Next(1, 30) + "  " + rnd.Next(31, 60) + "  " + rnd.Next(61, 90);
            Console.WriteLine(str);
        }
        static void task8()
        {
            Console.Write("введите кол-во см: ");
            double sm = Int32.Parse(Console.ReadLine());

            Console.WriteLine("полных метров: " + sm / 100 + " м");
        }
        static void task11()
        {
            //            11.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //a.А или В;
            //            b.А и В;
            //            c.В или С.
            bool a, b, c;

            Console.Write("введите цифру A: ");
            a = bool.Parse(Console.ReadLine());
            Console.Write("введите цифру B: ");
            b = bool.Parse(Console.ReadLine());
            Console.Write("введите цифру C: ");
            c = bool.Parse(Console.ReadLine());

            if (a || b)
            {
                Console.WriteLine("true");
            }
            if (a && b)
            {
                Console.WriteLine("false");
            }
            if (b || c)
            {
                Console.WriteLine("false");
            }

        }
        static void task15()
        {
            for (int i = 20; i <= 35; i++)
                Console.WriteLine(i);


            Console.Write("введите цифру B: ");
            int b = Int32.Parse(Console.ReadLine());
            if (b > 10)
            {
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            else Console.WriteLine("b меньше 10");



            Console.Write("введите цифру A: ");
            int a = Int32.Parse(Console.ReadLine());
            if (a < 50)
            {
                for (int i = a; i <= 50; i++)
                {
                    Console.WriteLine("{0}", Math.Pow(i, 3));
                }
            }
            else Console.WriteLine("a больше 50");


        }
        static void task16()
        {
            //16.вычисления значения функции y = 7x2 - 3x + 6 при любом значении x;

            Console.Write("введите x: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine((7 * x * x - 3 * x + 6));

        }
        static void task31()
        {
            // 31.Известны два расстояния: одно в километрах, другое — в футах (1 фут 0, 305 м ). Какое из расстояний меньше?
            Console.Write("введите кол-во в км: ");
            double km = Int32.Parse(Console.ReadLine());

            Console.Write("введите кол-во в футах: ");
            double f = Int32.Parse(Console.ReadLine());

            f *= 0.3 / 1000;

            if (km < f)
                Console.WriteLine("расстояние в км меньше");
            else if (km > f)
                Console.Write("расстояние в футах меньше");
        }
        static void task34()
        {
            Console.Write("введите цифру от 1 до 7: ");
            int a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
        }
        static void task37()
        {
            //37.Составить программу, которая в зависимости от порядкового номера месяца(1, 2, ..., 12) выводит на экран количество дней в этом месяце.
            //Рассмотреть два случая:
            //a.год не является високосным (см.задачу 4.65);
            //b.год может быть високосным (информация об этом вводится с клавиатуры).
            Console.Write("введите цифру от 1 до 12: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(2018, a));
        }

    }
}
