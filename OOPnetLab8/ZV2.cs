using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnetLab8
{

    /*
     Завдання 2:
        Написати статичний метод ReadFiles, що виконує вказані дії над вмістом файлу.
        Формальні параметри : файл, задана дія – об'єкт Action/Func.
        Використовуючи написаний метод:
             вивести вміст файлу на екран;
             вивести на екран всі числа! (числа складаються с цифр);
             замінити у файлі всі коми | крапки | * | () на пробіли.
        Після виклику останньої дії – вивести вміст файлу на екран.
    */
    class ZV2
    {
        public static void ZV2Main()
        {
            Console.WriteLine("-----------Show-----------");
            ReadFiles("ForZV2.txt", Show);
            Console.WriteLine("-----------ShowNumbers-----------");
            ReadFiles("ForZV2.txt", ShowNumbers);
            Console.WriteLine("-----------Rewrite and Show-----------");
            ReadFiles("ForZV2.txt", Rewrite);
            ReadFiles("ForZV2.txt", Show);
        }

        public static void ReadFiles(String path, Action<String> act)
        {
            act(path);
        }

        public static void Show(String path)
        {
            StringBuilder file = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                            file.Append(line+"\n");
            }
            Console.WriteLine(file);
        }

        public static void ShowNumbers(String path)
        {
            StringBuilder numbers = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    int i = 0;
                    while (i < line.Length)
                    {
                        while (i != line.Length && !Char.IsDigit(line[i]))
                            i++;
                        int j = i;
                        while (j != line.Length && Char.IsDigit(line[j]))
                            j++;

                        if (i != j)
                            numbers.Append(line.Substring(i,j-i)+" ");
                        i = j;
                    }
                }
            }
            Console.WriteLine(numbers);
        }

        public static void Rewrite(String path)
        {
            StringBuilder file = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                    file.Append(line + "\n");
            }

            file.Replace('(', ' ');
            file.Replace(')', ' ');
            file.Replace('.', ' ');
            file.Replace(',', ' ');
            file.Replace('*', ' ');

            using (StreamWriter MyFile = new StreamWriter(path))
            {
                MyFile.WriteLine(file);
            }
        }
    }
}
