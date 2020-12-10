using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    /* Задание №1 */
    public delegate void Method(string str);
    public delegate string Lab_Work();
    public delegate int Numbers(int a, int b);
    public delegate void Action<T>(T A);
    class User
    {
        public event Method Move;
        public event Method Squeeze;
        public void Move_folder(bool move) // Метод для перемещения файлов в папку
        {
            if (move == true)
            {
                Move?.Invoke("Файл перенесён в папку");
            }
            else
            {
                Move?.Invoke("Файл не перемещён в папку");
            }
        }
        public void Squeeze_folder(double a) // Метод для сжатия файла
        {
            if (a > 0)
            {
                Squeeze?.Invoke($"Сжатие файла выполнено! Коэффицент сжатия: {a}");
            }
            else
            {
                Squeeze?.Invoke("Ошибка! Коэффицент сжатия null или неккоректно введён");
            }
        }
    }
    /* Задание №2 */
    static public class Operetions_String
    {
        public static string Space(string str) // Метод для удаления лишнего пробела
        {
            int del = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    if (str[i + 1] == ' ')
                        del = i + 1;
            }
            str = str.Remove(del, 1);
            return str;
        }
        public static void Add_Sentence(string str_1, string str_2) // Метод для соединения двух строк
        {
            str_1 = str_1 + str_2;
            Console.WriteLine(str_1);
        }
        public static string One_Space(string str) // Метод для удаления пробела перед 1-м символом
        {
            if (str[0] == ' ')
                str = str.Remove(0, 1);
            return str;
        }
        public static string To_Upper(string str) // Метод для перевода в верхний регистр
        {
            str = str.ToUpper();
            return str;
        }

        public static string Happy(string str)  // Метод для добавления слова
        {
            str = str + " Happy!";
            return str;
        }
    }

    class Program
    {
        private static void DisplayMessage(string message) // Обработчик события
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            /* Тест задания №1 */
            Lab_Work str_0 = () => "Начнём тест нашего кода!"; // Лямбда выражения 
            Numbers num = (i, j) => i + j;
            int z = num(5, 4);
            Console.WriteLine(str_0() + " Лабораторная работа №" + z + "\n");

            User user_1 = new User();
            user_1.Move += DisplayMessage;
            user_1.Squeeze += DisplayMessage;
            Console.WriteLine("Пользователь №1:");

            bool f_1 = true;
            user_1.Move_folder(f_1);
            double n_1 = 1.8;
            user_1.Squeeze_folder(n_1);
            User user_2 = new User();
            user_2.Move += DisplayMessage;
            user_2.Squeeze += DisplayMessage;
            Console.WriteLine("Пользователь №2:");

            bool f_2 = false;
            user_2.Move_folder(f_2);
            double n_2 = 0;
            user_2.Squeeze_folder(n_2);
            User user_3 = new User();
            user_3.Move += DisplayMessage; 
            user_3.Squeeze += DisplayMessage;
            Console.WriteLine("Пользователь №3:");
            double n_3 = -1.8; 
            user_3.Squeeze_folder(n_3);
            User user_4 = new User();
            user_4.Move += DisplayMessage; 
            user_4.Squeeze += DisplayMessage;
            Console.WriteLine("Пользователь №4:");
            bool f_4 = true; 
            user_4.Move_folder(f_4);

            /* Тест задания №2 */
            string str_1 = "\nHello  world!";
            string str_2 = "Мороз и солнце ";
            Console.WriteLine(Operetions_String.Space(str_1));
            string str_3 = "день чудесный";
            Operetions_String.Add_Sentence(str_2, str_3);
            string str_4 = " I want to sleep...";
            Console.WriteLine(Operetions_String.One_Space(str_4));
            string str_5 = "Хочу Новый год";
            Console.WriteLine(Operetions_String.To_Upper(str_5));
            string str_6 = "Are you happy?";
            Console.WriteLine(Operetions_String.Happy(str_6));
            string str_8 = "\nЯ люблю котов и ";
            string str_9 = "конечно же собак!";
            Action<string, string> str_7;
            str_7 = Add;
            str_7(str_8, str_9);
            Console.Read();
        }
        static void Add(string str_1, string str_2) // Метод для соединения двух предложений
        {
            str_1 = str_1 + str_2;
            Console.WriteLine(str_1);
        }
    }
}
