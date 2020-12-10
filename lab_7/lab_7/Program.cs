using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_7
{
    class Program
    {

        abstract class Type
        {
            public string TypeOfFigure;
            public string Type_Of_Figure
            {
                get
                {
                    return this.TypeOfFigure;
                }
                set
                {
                    this.TypeOfFigure = value;
                }
            }

            
            public abstract string Smile(); // Одноименный метод
        }

        class Geometric_figure : Type
        {
            public int Angle;
            public int Square;

            public int Angle_Quantity
            {
                get
                {
                    return this.Angle;
                }

                set
                {
                    this.Angle = value;
                }
            }

            public int Square_figure // Исключение №1
            {
                get
                { return this.Square; }
                set
                {
                    if (Square == 0)
                    { throw new Figure_Exception_2("Данные введены некорректно!", Square); }
                    else
                    { this.Square = value; }
                }
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Тип фигуры: {Type_Of_Figure}, Количество углов: {Angle_Quantity}, Площадь фигуры: {Square_figure}");

            }

            public override string Smile() // Одноименный метод
            {
                string symbol = "^_^";
                return symbol;
            }
        }

        class Circle : Geometric_figure
        {
            public int Radius;
            public double Length;
            public int Radius_Circle // Исключение №2
            {
                get
                { return this.Radius; }
                set
                {
                    if (Radius == 0)
                    { throw new Exception("Данные не заполнены!"); }
                    else
                    { this.Radius = value; }
                }
            }
            public double Length_Circle
            {
                get
                {
                    return this.Length;
                }
                set
                {
                    this.Length = value;
                }
            }
            public override void GetInfo() // Переопределение метода GetInfo()
            {
                Console.WriteLine($"Радиус круга: {Radius_Circle} \nДлина окружности: {Length_Circle}");
                Console.WriteLine();
            }
        }

        sealed class Rectangle : Geometric_figure // Герметизированный класс
        {
            public int Length;
            public string Width;
            public int Length_Rectangle // Исключение №3
            {
                get
                { return this.Length; }
                set
                {
                    if (this.Length == 0)
                    { throw new Figure_Exception_1("Данные не заполнены или некорректно введены!"); }
                    else
                    { this.Length = value; }
                }
            }
            public string Width_Rectangle
            {
                get
                {
                    return this.Width;
                }
                set
                {
                    this.Width = value;
                }
            }
            public override void GetInfo()
            {
                Console.WriteLine($"Длина прямоугольника: {Length_Rectangle} \nШирина прямоугольника: {Width_Rectangle}");
                Console.WriteLine();
            }
            
        }



        /* Лабораторная работа №6 */
        enum Cup // Перечисление
        {
            Blue_Cup = 1,
            Violet_Cup,
            Green_Cup,
            Yellow_Cup,
            Red_Cup,
        };
        struct Tea // Структура
        {
            public int Green;
            public int Black;
            public int White;
            public int Green_Tea
            {
                get
                { return this.Green; }
                set
                { this.Green = value; }
            }
            public int Black_Tea
            {
                get
                { return this.Black; }
                set
                { this.Black = value; }
            }
            public int White_Tea
            {
                get
                { return this.White; }
                set
                { this.White = value; }
            }
            public void Created_Tea()
            {
                Console.WriteLine($"Чай\nЗелёный чай: {Green_Tea}%\nЧёрный чай: {Black_Tea}%\nБелый чай: {White_Tea}%\n");
            }
        }
        
       

        /* Лабораторная работа №7 */
        class Figure_Exception_1 : ArgumentException
        {
            public Figure_Exception_1(string message)
                : base(message)
            { }
        }
        class Figure_Exception_2 : Exception
        {
            public int Value { get; }
            public Figure_Exception_2(string message, int value)
                : base(message)
            { Value = value; }
        }


        static void Main(string[] args)
        {

            /* Лабораторная работа №7 */
            Tea person_1 = new Tea()
            {
                Green_Tea = 1,
                Black_Tea = 2,
                White_Tea = 3,
            };
            try
            {
                Circle figure_7 = new Circle
                {
                    Radius = 99,
                    Length = 2 * 3.14 * 6,
                };
            }
            catch (Exception e)
            { Console.WriteLine($"Ошибка: {e.Message}"); }
            finally
            {
                Console.WriteLine("Всё супер!");
            }
           

            try
            {
                Rectangle figure_8 = new Rectangle
                {
                    Length_Rectangle = 0,
                    Width_Rectangle = "23",
                };
            }
            catch (Figure_Exception_1 ex_1)
            { Console.WriteLine($"Ошибка: {ex_1.Message}"); }


            try
            {
                Geometric_figure figure_9 = new Geometric_figure
                {
                    Type_Of_Figure = "Многоугольник",
                    Angle = 23,
                    Square = 18,
                };
            }
            catch (Figure_Exception_2 ex_2)
            {
                Console.WriteLine($"Ошибка: {ex_2.Message}");
            }
            finally
            {
                Console.WriteLine("Всё супер!");
            }
            

            Debug.Assert(person_1.Black_Tea != 2, "Чёрный чай есть");
            Debug.Assert(person_1.White_Tea == 3, "Белого чая нет");
            
            Console.ReadKey();
        }
    }

}

