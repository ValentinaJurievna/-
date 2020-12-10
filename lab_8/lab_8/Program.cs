using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_8
{
    public interface IControl<T> where T : struct // Ограничение на тип значение
    {
        void Push(T element);
        void See(Array<T> A);
    }
    public class Array<T> 
    {
        public List<T> list = new List<T>();
        public int Count
        {
            get
            { return this.list.Count; }
        }
        public void Push(T element)
        { 
            list.Add(element); 
        }
        public void See(Array<T> A) // Метод See()
        {
            Console.WriteLine("Массив: ");
            foreach (T i in A.list)
            { 
                Console.Write($"{i}\t"); 
            }
            Console.WriteLine("\n");
        }
       
        public T this[int index]
        {
            get
            { return this.list[index]; }
            set
            { this.list[index] = value; }
        }
        public static string operator *(Array<T> stack, T element) // Добавление элемента в массив
        {
            stack.Push(element);
            return ("Миссия по добавлению элемента в массив выполнена!");
        }
        public static string operator /(Array<T> a, T b) // Проверка на вхождение элемента
        {
            if (a.list.Contains(b))
            { return ($"Элемент {b} находится в массиве {a}.\n"); }
            else
            { return ($"Элемент {b} не находится в массиве {a}.\n"); }
        }
        public static string operator +(Array<T> a, Array<T> b) // Объединение двух массивов
        {
            T[] c = new T[a.Count + b.Count]; int k = 0;
            for (int i = 0; i < a.Count; i++)
            { 
                c[k] = a[i]; k++; 
            }
            for (int j = 0; j < b.Count; j++)
            { 
                c[k] = b[j]; k++; 
            }
            Console.Write("Наш новый массив:\t");
            for (int i = 0; i < k; i++)
            { 
                Console.Write($"{c[i]}\t"); 
            }
            return ($"\nРазмерность массива: {k}\n");
        }
    }
    static public class Operations // Пользовательский класс
    {
        static int count;
        static int sum;
        public static void Sum(Array<int> A) // Сумма элементов
        {
            foreach (int i in A.list)
            { sum += i; }
            Console.WriteLine($"Сумма элементов: {sum}.\n");
        }
   
        public static void Count(Array<int> A) // Количество всех элементов
        {
            foreach (int i in A.list)
            { count++; }
            Console.WriteLine($"Количество элементов: {count}.\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Array<int> massiv_1 = new Array<int>();
                massiv_1.Push(1); massiv_1.Push(2); massiv_1.Push(3);
                massiv_1.Push(4); massiv_1.Push(5); massiv_1.Push(6);

                Array<double> massiv_2 = new Array<double>();
                massiv_2.Push(1.2); massiv_2.Push(2.3); massiv_2.Push(3.4);
                massiv_2.Push(4.5); massiv_2.Push(5.6); massiv_2.Push(6.7);

                massiv_1.See(massiv_1); massiv_2.See(massiv_2);

                var w_1 = massiv_1 * (7); var w_2 = massiv_2 * (1.5);
                massiv_1.See(massiv_1); massiv_2.See(massiv_2);
                Console.WriteLine(massiv_1 / (5));
                Console.WriteLine(massiv_1 / (0));

                Array<double> massiv_3 = new Array<double>();
                massiv_3.Push(7.8); massiv_3.Push(8.9); massiv_3.Push(9.1);
                Console.WriteLine(massiv_2 + massiv_3);
                Operations.Count(massiv_1);
            }
            finally
            { Console.WriteLine("Обобщение выполнено!"); }
            Console.ReadLine();
        }
    }
}
