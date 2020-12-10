using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__10
{
    class Airline // Класс из Лабораторной работы №3
    {
        private string PointOfDestination;
        private string NumberRice;
        private string TypeOfPlane;
        private int TimeTo;
        private string DaysOfWeek;
        public string Point_Of_Destination
        {
            get
            { return this.PointOfDestination; }
            set
            { this.PointOfDestination = value; }
        }
        public string Number_Rice
        {
            get
            { return this.NumberRice; }
            set
            { this.NumberRice = value; }
        }
        public string Type_Of_Plane
        {
            get
            { return this.TypeOfPlane; }
            set
            { this.TypeOfPlane = value; }
        }
        public int Time_To
        {
            get
            { return this.TimeTo; }
            set
            { this.TimeTo = value; }
        }
        public string Days_Of_Week
        {
            get
            { return this.DaysOfWeek; }
            set
            { this.DaysOfWeek = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Пункт отправления и назначения: {Point_Of_Destination} \nНомер рейса: {Number_Rice} \nТип самолёта: {Type_Of_Plane}");
            Console.Write($"Время отправления: {Time_To} \nДни полётов: {Days_Of_Week} \n");
            Console.WriteLine();
        }
    }
    class Group
    {
        public string Name_Student { get; set; }
        public int Number_of_Group { get; set; }
    }
    class Faculty
    {
        public int Number_of_Group { get; set; }
        public string Faculty_Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.Write("Введите параметр n: "); // последовательность месяцев с длиной строки равной n
            int n = int.Parse(Console.ReadLine());
            IEnumerable<string> Months_1 = Months.Where(m => m.Length == n);
            Console.WriteLine("Наш полученный массив (1): ");
            foreach (string i in Months_1)
            { Console.Write(i + "   "); }
            IEnumerable<string> Months_2 = from m in Months where m.StartsWith("D") || m.StartsWith("J") || m.StartsWith("F") || m.StartsWith("Au") select m; // Запрос, выбирающий только летние и зимние месяцы
            Console.WriteLine("\nНаш полученный массив (2): ");
            foreach (string i in Months_2)
            { Console.Write(i + "   "); }
            IEnumerable<string> Months_3 = Months.OrderBy(s => s);
            Console.WriteLine("\nНаш полученный массив (3): ");
            foreach (string i in Months_3)
            { Console.Write(i + "   "); }
            Console.WriteLine("\nНаш полученный массив (4): ");
            IEnumerable<string> Months_4 = Months.Where(n_1 => n_1.Contains("u") && n_1.Length >= 4);
            foreach (string i in Months_4)
            { Console.Write(i + "   "); }

            Airline person_1 = new Airline
            {
                Point_Of_Destination = "Минск-Москва",
                Number_Rice = "А192",
                Type_Of_Plane = "УП-4",
                Time_To = 17,
                Days_Of_Week = "Четверг",
            };
            Airline person_2 = new Airline
            {
                Point_Of_Destination = "Москва-Сингапур",
                Number_Rice = "К5698",
                Type_Of_Plane = "СП-62",
                Time_To = 23,
                Days_Of_Week = "Пятница",
            };
            Airline person_3 = new Airline
            {
                Point_Of_Destination = "Сингапур-Австралия-Новая Зеландия",
                Number_Rice = "Ф54872",
                Type_Of_Plane = "Боинг-7",
                Time_To = 11,
                Days_Of_Week = "Вторник",
            };
            Airline person_4 = new Airline
            {
                Point_Of_Destination = "Берлин-Минск",
                Number_Rice = "Q877",
                Type_Of_Plane = "Б-747",
                Time_To = 14,
                Days_Of_Week = "Среда",
            };
            Airline person_5 = new Airline
            {
                Point_Of_Destination = "Токио-Пекин",
                Number_Rice = "А873",
                Type_Of_Plane = "Н-134",
                Time_To = 21,
                Days_Of_Week = "Понедельник",
            };
            List<Airline> list_1 = new List<Airline>();
            list_1.Add(person_1); list_1.Add(person_2); list_1.Add(person_3); list_1.Add(person_4); list_1.Add(person_5);
            Console.Write("\n\n(1)Введите маршрут рейса: ");
            string Point = Console.ReadLine();
            var Airline_1 = list_1.Where(n_2 => n_2.Point_Of_Destination == Point);
            Console.WriteLine("Информация о рейсе:");
            foreach (Airline i in Airline_1)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }

            Console.Write("\n(2)Введите день недели: ");
            string Day = Console.ReadLine();
            var Airline_2 = from n_3 in list_1 where n_3.Days_Of_Week == Day select n_3;
            Console.WriteLine("Информация о рейсе:");
            foreach (Airline i in Airline_2)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }

            string Day_1 = "Понедельник";
            var Airline_3 = from n_4 in list_1 where n_4.Time_To >= 10 && n_4.Days_Of_Week == Day_1 select n_4;
            Console.WriteLine("\n(3)Информация о рейсе:");
            foreach (Airline i in Airline_3)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }
            string Day_2 = "Среда";
            string Day_3 = "Пятница";
            var Airline_4 = from n_5 in list_1 where (n_5.Days_Of_Week == Day_2) || (n_5.Days_Of_Week == Day_3 && n_5.Time_To >= 20) select n_5;
            Console.WriteLine("\n(4)Информация о рейсе:");
            foreach (Airline i in Airline_4)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }

            var Airline_5 = list_1.OrderBy(n_6 => n_6.Time_To); // Упорядочивание рейсов по времени отправления
            Console.WriteLine("\n(5)Информация о рейсе:");
            foreach (Airline i in Airline_5)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }

            var Airline_6 = list_1.Skip(3).Take(1);
            Console.WriteLine("\n(6)Информация о рейсе:");
            foreach (Airline i in Airline_6)
            {
                Console.WriteLine($"Пункт отправления и назначения: {i.Point_Of_Destination} \nНомер рейса: {i.Number_Rice} \nТип самолёта: {i.Type_Of_Plane}");
                Console.Write($"Время отправления: {i.Time_To} \nДни полётов: {i.Days_Of_Week} \n");
            }

            List<Group> group = new List<Group>() //  Работаем с методом расширения Join
            {
                new Group { Name_Student = "Girl", Number_of_Group = 15},
                new Group { Name_Student = "Boy", Number_of_Group = 7 }
            };
            List<Faculty> faculty = new List<Faculty>()
            {
                new Faculty {Faculty_Name = "IT", Number_of_Group = 7},
                new Faculty {Faculty_Name = "International relations", Number_of_Group = 15},
            };
            var res_1 = group.Join(faculty, p => p.Number_of_Group, t => t.Number_of_Group, (p, t) => new { Name = p.Name_Student, Group_G = p.Number_of_Group, Faculty_N = t.Faculty_Name });
            Console.WriteLine("\n\nSome information about students:");
            foreach (var i in res_1)
                Console.WriteLine($"{i.Name} - {i.Group_G} ({i.Faculty_N})");
            Console.ReadKey();
        }
    }
}
