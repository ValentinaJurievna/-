using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Типы 1_a
            bool b = true;
            byte bit = 200;
            sbyte bit1 = -100;
            short n = 30000;
            ushort u = 1;
            int a = -2898;
            uint c = 2232;
            long d = 289787;
            ulong ul = 0b101;
            float w = 3.4673f;
            double f = -5.212;
            decimal g = Convert.ToInt32(Math.Pow(11, -19));
            char s = '\x5A';
            string name = "name";
            object m = 55;
            dynamic dym = 45;

            Console.WriteLine($"Name: {name}");



            // 1_b
            w = (float)f;
            bit = (byte)bit1;
            ul = (ulong)d;
            n = (short)u;
            m = (object)dym;
            Console.WriteLine( $"{m}" );

            ul = s;
            d = a;
            m = d;
            f = bit1;
            g = dym;
            Console.WriteLine($"{f}");


            // 1_c

            int x = 5;
            object o = x; //упаковка x
            int r = (int)o; //распаковка x


            //1_d



            //1_e
            int? y = null;
            int z = y ?? 9; //null-объединение
            Console.WriteLine($"{z}");

            Console.WriteLine("---------------------------");


            //Строки 2_a
            string str_1 = "Hello";
            string str_2 = "worldy";
            int result = String.Compare(str_1, str_2);
            if (result < 0)
            {
                Console.WriteLine("Строка str_1 меньше строки str_2");
            }

            else if (result > 0)
            {
                Console.WriteLine("Строка str_1 больше строки str_2");
            }

            else
            {
                Console.WriteLine("Строки равны");
            }
           
            

            //2_b
            string str_3 = "I ";
            string str_4 = "love ";
            string str_5 = "programming";
            Console.WriteLine(String.Concat(str_3, str_4, str_5));

            string str_6 = String.Copy(str_5);
            Console.WriteLine(str_6);
            Console.WriteLine(str_6.Insert(2, "ooo"));
            Console.WriteLine(str_6.Substring(5));

            string str_7 = "Valya Nadya Angelina";
            string[] girls = str_7.Split(' ');
            Console.WriteLine(girls[2]);

            Console.WriteLine(str_6.Remove(5));


            //2_c
            string str_8 = String.Empty;
            string str_9 = null;
            Console.WriteLine(str_8.Length);
            bool sr = (str_8 == str_9);
            Console.WriteLine(sr);


            //2_d 
            StringBuilder str_10 = new StringBuilder("The best day");
            Console.WriteLine(str_10.Length);
            Console.WriteLine(str_10.Capacity);
            Console.WriteLine(str_10.Remove(3, 5));
            Console.WriteLine(str_10.Append(" all"));
            Console.WriteLine(str_10.Insert(0, "All "));

            Console.WriteLine("---------------------------");


            //Массивы 3_a
            int[,] Arr = { {23, 45, 34, 23, 33 }, {23, 4, 1, 56, 67} } ;
            for (int i=0; i<2; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------");

            //3_b
            int[] array = { 45, 76, 99 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(array.Length);

            Console.WriteLine("Введите индекс, который хотите изменить: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение: ");
            int value = Convert.ToInt32(Console.ReadLine());
            array[index] = value;
            Console.WriteLine("Измененный массив строк: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("-------");

            //3_с
            int[][] myArray = new int[3][];
            myArray[0] = new int[2];
            myArray[1] = new int[3];
            myArray[2] = new int[4];
            for (int t = 0; t < 3; t++)
            {
                for (int l = 0; l < myArray[t].Length; l++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    myArray[t][l] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int t = 0; t < 3; t++)
            {
                for (int l = 0; l < myArray[t].Length; l++)
                {
                    Console.Write(myArray[t][l] + "  ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("-------");

            //3_d
            var www = new[] { 1, 2, 3, 4 };
            for (int me = 0; me < www.Length; me++)
            {
                Console.Write(www[me] + " ");
            }
            Console.WriteLine();

            var www_2 = new[] { "My", "name", "is", "Valya" };
            for (int me_2 = 0; me_2 < www_2.Length; me_2++)
            {
                Console.Write(www_2[me_2] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("---------------------------");

            //4_a_b
            int tu1 = 9;
            string tu2 = "life";
            char tu3 = 'M';
            string tu4 = "happy";
            ulong tu5 = 99;
            var tuple1 = Tuple.Create<int, string, char, string, ulong>(tu1, tu2, tu3, tu4, tu5);
            var tuple2 = Tuple.Create<int, string, char, string, ulong>(tu1, tu2, tu3, tu4, tu5);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item5);

            Console.WriteLine("-------");

            //4_c
            int four_1 = (int)tuple1.Item1;
            string four_2 = (string)tuple1.Item2;
            char four_3 = (char)tuple1.Item3;
            string four_4 = (string)tuple1.Item4;
            ulong four_5 = (ulong)tuple1.Item5;

            //4_d
            if (tuple1 == tuple2)
            {
                Console.WriteLine("Кортежи равны");
            }

            //5
            int[] massiv = { 1, 34, 93, 98, 21 };
            string str = "hello";
            Console.WriteLine(foo(massiv, str));



            static Tuple<int, int, int, char> foo(int[] mas, string str_11)
            {
                int min = 99, max = 0, sum = 0; 
                char h;
                foreach (int key in mas)
                {
                    if (key > max) { max = key; }
                    if (key < min) { min = key; }
                    sum += key;
                }
                h = str_11[0];
                var tuples = Tuple.Create<int, int, int, char>(min, max, sum, h);
                return tuples;
            }

            Console.ReadLine();
        }
    }
}
