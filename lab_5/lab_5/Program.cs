using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
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

            public int Square_figure
            {
                get
                {
                    return this.Square;
                }

                set
                {
                    this.Square = value;
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
            public int Radius_Circle
            {
                get
                { 
                    return this.Radius; 
                }
                set
                { 
                    this.Radius = value; 
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
            public override void GetInfo() // Переопределение метода
            {
                Console.WriteLine($"Радиус круга: {Radius_Circle} \nДлина окружности: {Length_Circle}");
                Console.WriteLine();
            }
        }

        sealed class Rectangle : Geometric_figure // Герметизированный класс
        {
            public int Length;
            public string Width;
            public int Length_Rectangle
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
            public override string ToString()
            {
                return ("Type: " + base.ToString() + "; Length: " + Length_Rectangle + "; Width: " + Width_Rectangle);
            }

            public static Boolean // Переопределение метода Equals()
            ReferenceEquals(Object A, Object B)
            {
                return (A == B);
            }
            public override int GetHashCode()
            {
                int hash_code = 270;
                hash_code = string.IsNullOrEmpty(Width_Rectangle) ? 0 : Width_Rectangle.GetHashCode();
                hash_code = (hash_code * 50);
                return hash_code;
            }
        }

        interface IControl
        {
            string Smile();
        }

        class Button : IControl
        {
            public string Smile()
            {
                string symbol = "(:))";
                return symbol;
            }
        }


        static void Main(string[] args)
        {
            Geometric_figure figure_1 = new Geometric_figure
            {
                Type_Of_Figure = "Квадрат",
                Angle_Quantity = 4,
                Square_figure = 90,
            };
            Console.WriteLine("Фигура №1");
            figure_1.GetInfo();

            Circle figure_2 = new Circle
            {
                Radius_Circle = 4,
                Length_Circle = 2 * 3.14 * 4,
            };
            Console.WriteLine("Фигура №2");
            figure_2.GetInfo();

            Rectangle figure_3 = new Rectangle
            {
                Length_Rectangle = 4,
                Width_Rectangle = "15",
            };
            Console.WriteLine("Фигура №3");
            figure_3.GetInfo();

            Console.WriteLine(figure_3.ToString());
            Console.WriteLine($"Фигура №1 и фигура №3 равны? -> {ReferenceEquals(figure_1, figure_3)}");
            Console.WriteLine($"Хэш-код: {figure_3.GetHashCode()}");
            Console.WriteLine(figure_1.Smile());

            Button button_1 = new Button { };
            Console.WriteLine(button_1.Smile());


            if (figure_2 is Rectangle)
            {
                Console.WriteLine("Да, фигура является прямоугольником");
            }
            else
            {
                Console.WriteLine("Это не прямоугольник");
            }

            Circle figure_4 = figure_2 as Circle;
            if (figure_4 == null)
            {
                Console.WriteLine("Неудачное преобразование");
            }
            else
            {
                Console.WriteLine("Преобразование выполнено успешно!");
            }
            Console.ReadKey();
        }
    }
        
}

