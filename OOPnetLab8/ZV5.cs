using System;
using System.Collections.Generic;
using System.Text;


namespace OOPnetLab8
{
    class ZV5
    {
        /*Завдання 5
            Оголосіть два делегати: UseOperation, GetGreeting.
            Перший делегат посилається на функцію, яка в якості параметрів приймає два значення типу int і повертає
            деяке ціле число.
            Другий делегат посилається на метод без параметрів, який нічого не повертає.
                 Створіть методи без параметрів GoodMorning, GoodDay, GoodEvening і GoodNight, при виклику яких
                    виводиться текст «Доброго ранку!», «Добрий день!», «Добрий вечір!» і «Доброї ночі!». Якщо відомо, що
                    властивість DateTime.Now.Hour повертає кількість годин поточного часу, то напишіть програму, в якій, за
                    допомогою делегата GetGreeting, запускається один з написаних вами методів, в залежності від поточного
                    значення часу.
                 Створіть методи для обчислення суми, різниці, добутку, частки двох цілих чисел.
                    Використовуючи делегат UseOperation для виклику описаних в попередньому пункті методів, напишіть
                    програму, яка запитує у користувача два цілих числа і операцію, яку необхідно провести. Виводить відповідний
                    результат.*/

        public delegate int UseOperation(int a, int b);
        public delegate void GetGreeting();
        public static void ZV5Main()
        {
            int hourNow = DateTime.Now.Hour;
            GetGreeting getG;
            if (hourNow >= 4 && hourNow < 11) getG = GoodMorning;
            else if (hourNow >= 11 && hourNow < 18) getG = GoodDay;
            else if (hourNow >= 18 && hourNow < 21) getG = GoodEvening;
            else  getG = GoodNight;
            getG();


            Dictionary<string, UseOperation> useOp = new Dictionary<string, UseOperation>
            {
                { "+", Sum },
                { "-", Minus },
                { "*", Mult },
                { "/", Division },
            };
            int a, b;
            string sign;
            do {
                Console.Write("\nPlease choose option( + , - , * , / ):");
                sign = Console.ReadLine();
                if (useOp.ContainsKey(sign))
                    break;
                Console.WriteLine("Please try egain enter correct sign!");
            } while (true);


            Console.WriteLine("Enter numbers a and b for choosed option:");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            try
            {
                int res = +useOp[sign](a, b);
                Console.WriteLine(a + " " + sign + " "+ b +" = " + res);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GoodMorning()
        {
            Console.WriteLine("Good morning!");
        }
        public static void GoodDay()
        {
            Console.WriteLine("Good day!");
        }
        public static void GoodEvening()
        {
            Console.WriteLine("Good evening!");
        }
        public static void GoodNight()
        {
            Console.WriteLine("Good night!");
        }


        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("the number b must not be zero");
            return a / b;
        }

    }
}
