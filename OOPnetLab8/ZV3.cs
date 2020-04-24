using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnetLab8
{

    /*Завдання 3
        Оголосити тип делегату, що посилається на метод. Вимоги до сигнатури методу наступні:
             метод отримує вхідним параметром змінну типу double;
             метод повертає значення типу double, яке є результатом обчислення згідно з умовою задачі.
        Реалізувати виклик трьох методів з допомогою одного делегату, які отримують радіус кола R в якості
        вхідного параметру і обчислюють:
             довжину кола за формулою D = 2πR;
             площу круга за формулою S = πR2;
             об‘єм кулі. Формула V = 4/3πR3.
        Методи повинні бути представлені в окремому класі як нестатичні.*/
    class ZV3
    {

        delegate double DelegateR(double r);
        public static void ZV3Main()
        {
            double r,res;
            ForZV3 functions = new ForZV3();
            DelegateR del;
            Console.Write("Please enter R for next operations: ");
            r = Double.Parse(Console.ReadLine());

            del= functions.CircleD;
            try
            {
                res = del(r);
                Console.WriteLine("D = "+res.ToString("0.000"));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            del = functions.CircleS;
            try
            {
                res = del(r);
                Console.WriteLine("S = " + res.ToString("0.000"));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            del = functions.CircleV;
            try
            {
                res = del(r);
                Console.WriteLine("V = " + res.ToString("0.000"));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


        }


    }
}
