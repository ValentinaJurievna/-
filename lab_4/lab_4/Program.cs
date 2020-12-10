using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array Array_1 = new Array(); //создание двух новых объектов
            Array Array_2 = new Array();
            Array_1 = Array_1 * (-1); Array_1 = Array_1 * (2); Array_1 = Array_1 * (-3); // Наполнение массива новыми элементами
            Array_2 = Array_2 * (4); Array_2 = Array_2 * (-5); Array_2 = Array_2 * (6);
            Console.Write("Элементы массива №1:\t");
            for (int i = 0; i < Array_1.Count; i++)
                Console.Write($"{Array_1[i]}\t");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    static class StatisticOperation
    {
        public static string Delete_Vowels(this string Str)  // Метод удаления гласных из строки
        {
            string[] Str_0 = { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я", "А", "Е", "Ё", "И", "О", "У", "Ы", "Э", "Ю", "Я" };
            foreach (var c in Str_0)
            {
                Str = Str.Replace(c, string.Empty);
            }
            return Str;
        }
        public static string Delete_Five(this string Str)  // Метод удаления первых пяти элементов
        {
            string New_String = Str.Remove(0, 5);
            return New_String;
        }
    }

    class Array
    {
        private List<int> storage; // Инициализация коллекции int элементов
        public class Owner
        {
            public int ID;
            public string name;
            public string organization;
            public Owner(int ID, string name, string organization)
            {
                this.ID = ID;
                this.name = name;
                this.organization = organization;
            }
            public class Date
            {
                DateTime date_time = DateTime.Now;
                public override string ToString()
                {
                    return date_time.ToString();
                }
            }

            public List<int> storage
            {
                get
                { return this.storage; }
            }
            public int Count // Подсчёт элементов в массиве
            {
                get
                { return this.storage.Count; }
            }
            public int Push(int element) // Добавление в массив элемента
            {
                this.storage.Add(element);
                return element;
            }

            public int this[int index] // Индексатор
            {
                get
                { return this.storage[index]; }
                set
                { this.storage[index] = value; }
            }

            public static Array operator *(Array stack, int element) // Добавление элемента в массив
            {
                stack.Push(element);
                return stack;
            }

            public static bool operator >(Array a, int b) //Проверка на вхождение элемента
            {
                int n = 0;
                bool t = true;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] == b)
                    {
                        Console.WriteLine("Данное число принадлежит массиву");
                        n++;
                        break;
                    }
                    if (n == 0)
                    {
                        Console.WriteLine("Данное число не принадлежит массиву");
                    }
                    return t;
                }
            }

            public static int operator +(Array a, Array b) //Объединение двух массивов
            {
                var c = new int[a.Count + b.Count];
                int k = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    c[k] = a[i];
                    k++;
                }
                for (int i = 0; i < b.Count; i++)
                {
                    c[k] = b[i];
                    k++;
                }
                Console.Write("Новый массив: ");
                for (int i = 0; i < (a.Count + b.Count); i++)
                {

                    Console.Write($"{c[i]}");
                }
                return k;
            }

            public static int operator -(Array a, int b) // Разность со скалярным значением
            {
                int k = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    a[i] = a[i] - b;
                }
                Console.Write("Получаем такой массив:\t");
                for (int i = 0; i < a.Count; i++)
                {
                    Console.Write($"{a[i]}\t");
                }
                return k;
            }
        }
    }
}



