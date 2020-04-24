using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnetLab8
{

    /*Завдання 4.
        Розібрати приклад
        Постановка задачі – Створити колекцію, ключем в якій буде значення рядка, а значенням –метод/делегат*/
    class ZV4
    {
        delegate int Operation(int a, int b);
        public static void ZV4Main()
        {
            Dictionary<String, Operation> op = new Dictionary<String, Operation>();
            op["add"] = (a, b) => a + b;
            op["mult"] = (a, b) => a * b;
            Console.WriteLine("Add(5,3) = "+op["add"](5, 3));
            Console.WriteLine("Mult(6,7) = "+op["mult"](6, 7));
        }
    }
}
