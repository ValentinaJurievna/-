using lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    partial class Airline
    {
        private string point;
        private int number;
        private string type;
        private string time;
        private string day;

        //свойства классов
        public string Point
        {
            get
            {
                if (point != "" || point != null)
                {
                    return this.point;
                }
                else
                {
                    return "Данных нет";
                }
            }
            set
            {
                this.point = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {

                number = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string Day
        {
            get
            {
                return this.day;
            }
            set
            {
                this.day = value;
            }
        }

        public override string ToString()
        {
            return $"{point}, {number}, {day}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Airline air = (Airline)obj;
            return (this.Day == air.Day);
        }
    }
    partial class Airline
    {
        //конструкторы
        public Airline()
        {

        }
        public Airline(string m)
        {
            day = m;
            number = 45;
        }

        public Airline(string p, string m, int n)
        {
            point = p;
            day = m;
            number = n;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Point: {point},\n Day: {day},\n Number: {number},\n Type: {type},\n Time: {time}");

        }


        public Airline(string point, int number, string type, string time, string day)
        {
            this.point = point;
            if (number > 0)
            {
                this.number = number;
            }
            else
            {
                this.number = 0;
            }
            this.type = type;
            this.time = time;
            this.day = day;

        }

        static Airline()
        {
            Console.WriteLine("Статический конструктор");
        }

        private Airline(string p, int n, string t)
        {
            point = p;
            number = n;
            type = t;
        }

        public readonly int q = 99;
        const double pi = 3.14;

        //ref
        /*
         static void Main(string[] args)
         {
             int a = 9;
             Console.WriteLine($"Начальное значение a: {a}");
             Function(ref a);
             Console.WriteLine($"Значение после передачи по ссылке a: {a}");
         }
            static void Function(ref int x)
            {
                x++;
                Console.WriteLine($"Function: {x}");
            }
        */

        //out
        /*
        static void Main(string[] args)
        {
            int x = 10;
            int z, o;
            Math(x, 15, out z, out o);

            Console.WriteLine("Сумма: " + z);
            Console.WriteLine("Разность: " + o);

            Console.ReadKey();
        }
        static void Math(int x, int y, out int a, out int b)
        {
            a = x + y;
            b = x - y;
        }
        */
    }
       
}


    class Program
    {
        static void Main(string[] args)
        {
            Airline one = new Airline();
            Airline two = new Airline("Monday");
            Airline three = new Airline("Minsk-Moscow","Friday", 15);
            one.GetInfo();
            two.GetInfo();
            three.GetInfo();

            Airline four = new Airline { Point = "minsk", Number = 65, Day = "Friday" };
            Console.WriteLine(four.ToString());
            Console.WriteLine(four.GetHashCode());
            Console.WriteLine(four.GetType());

            //Реализация Equals
            Airline air_1 = new Airline { Day = "Monday" };
            Airline air_2 = new Airline { Day = "Monday" };
            Console.WriteLine(air_1.Equals(air_2));


            Airline stat = new Airline(); //статический конструктор


            Airline person_1 = new Airline // Создаём новые экземпляры класса
            {
                Point = "Минск-Москва",
                Number = 152,
                Type = "Туполев ТУ-134",
                Time = "17.34",
                Day = "Четверг",
            };
            Airline person_2 = new Airline
            {
                Point = "Москва-Сингапур",
                Number = 5698,
                Type = "Ильюшин ИЛ-62",
                Time = "2.13",
                Day = "Пятница",
            };
            Airline person_3 = new Airline
            {
                Point = "Сингапур-Австралия-Новая Зеландия",
                Number = 54872,
                Type = "Боинг-747",
                Time = "11.15",
                Day = "Вторник",
            };

            Console.Write("Введите название маршрута: "); // Поиск рейсов по маршруту
            string Point = Console.ReadLine();
            Console.WriteLine($"Рейсы по маршруту {Point}:\n");
            if (Point == person_1.Point)
            {
                person_1.GetInfo();
            }
            if (Point == person_2.Point)
            {
                person_2.GetInfo();
            }
            if (Point == person_3.Point)
            {
                person_3.GetInfo();
            }
            Console.Write("Введите день недели: "); // Поиск рейсов по дню недели
            string Day = Console.ReadLine();
            Console.WriteLine($"Рейсы в {Day}:\n");
            if (Day == person_1.Day)
            {
                person_1.GetInfo();
            }
            if (Day == person_2.Day)
            {
                person_2.GetInfo();
            }
            if (Day == person_3.Day)
            {
                person_3.GetInfo();
            }

            Console.ReadLine();
        }
    }

