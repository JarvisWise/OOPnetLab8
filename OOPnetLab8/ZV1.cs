using System;
using System.Collections.Generic;
using System.Text;


namespace OOPnetLab8
{

    /*
      Завдання 1:
        Написати статичний метод ChangeMatrix, що виконує вказані дії над елементами матриці дійсних чисел
        (матрицю заповнити рандомно або з файла!! в Main()).
        Формальні параметри : матриця дійсних чисел, задана дія – об'єкт Action/Func.
        Використовуючи написаний метод:
             вивести матрицю на екран;
             вивести на екран позитивні (>=0) елементи матриці;
             збільшити в три рази всі позитивні елементи матриці.
        Після виклику останньої дії – вивести змінену матрицю на екран.
        static void MethodAct (int[,] arr, Action<int> act)
        static void MethodFunc(int[,] arr, Func<int, int> act)
        static void Show(int num)
        static void ShowPositive(int num)
        static int Mult3(int num)
        static void Main(string[] args).
        */

    class ZV1
    {
        public static void ZV1Main()
        {
            int[,] Matrix = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i != Matrix.GetLength(0); i++)
                for (int j = 0; j != Matrix.GetLength(1); j++)
                    Matrix[i, j] = rnd.Next()%2001 - 1000;

            Console.WriteLine("---------------Show-----------------");
            try
            {
                MethodAct(Matrix, Show);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------ShowPositive-------------");
            try
            {
                MethodAct(Matrix, ShowPositive);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("---------------Mult3-----------------");
            try
            {
                    MethodFunc(Matrix, Mult3);
                    MethodAct(Matrix, Show);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-------------------------------------");

        }

        public static void MethodAct(int[,] arr, Action<int> act)
        {
            if (arr == null)
                throw new NullReferenceException("Array is empty");
            for (int i = 0; i != arr.GetLength(0); i++)
            {
                for (int j = 0; j != arr.GetLength(1); j++)
                    act(arr[i,j]);
                Console.WriteLine();
            }

        }
        public static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            if (arr == null)
                throw new NullReferenceException("Array is empty");
            for (int i = 0; i != arr.GetLength(0); i++)
                for (int j = 0; j != arr.GetLength(1); j++)
                    arr[i,j] = act(arr[i, j]);
        }
        public static void Show(int num)
        {
            Console.Write(String.Format("{0,6}", num));
        }
        public static void ShowPositive(int num)
        {
            if(num>=0)
                Console.Write(String.Format("{0,6}", num));
            else
                Console.Write(new String(' ',6));
        }
        public static int Mult3(int num)
        {
            if (num > 0)
                return num * 3;
            else
                return num;
        }

    }
}
