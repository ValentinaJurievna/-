using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise__9
{
    class Student // Класс для работы с обобщенной коллекцией
    {
        string Name { get; set; }
        int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Geometric_figure : Type // Класс из Лабораторной работы №5
    {
        public int Angle;
        public int Square;
        public int Angle_Quantity
        {
            get
            { return this.Angle; }
            set
            { this.Angle = value; }
        }
        public int Square_Figure
        {
            get
            { return this.Square; }
            set
            { this.Square = value; }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Тип фигуры: {Type_Of_Figure} \nКоличество углов: {Angle_Quantity} \nПлощадь фигуры: {Square_Figure} (м^2)");
            Console.WriteLine();
        }
        public override string Smile()
        {
            string symbol = "~(@^_^@)~";
            return symbol;
        }
    }
    abstract class Type
    {
        public string TypeOfFigure;
        public string Type_Of_Figure
        {
            get
            { return this.TypeOfFigure; }
            set
            { this.TypeOfFigure = value; }
        }
        public abstract string Smile();
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list_1 = new ArrayList(); // Необобщенная коллекция
            Random Rand_Numbers = new Random();
            for (int i = 0; i < 5; i++)
            { 
                list_1.Add(Rand_Numbers.Next(0, 50)); 
            }
            string str_1 = "Programming";
            list_1.Add(str_1);
            Student student_1 = new Student("Ivan", 21);
            list_1.Add(student_1);
            Console.WriteLine("Необобщенная коллекция: ");
            foreach (object i in list_1)
            {
                Console.Write(i + "\t");
            }
            list_1.RemoveAt(2);
            list_1.Remove(student_1);
            Console.WriteLine("\nОбновленная необобщенная коллекция: ");
            foreach (object i in list_1)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine($"\nСодержится ли данный элемент (student_1) в коллекции? { list_1.Contains(student_1) }");
            Console.WriteLine($"Содержится ли данный элемент (str_1) в коллекции? {list_1.Contains(str_1)}\n\n");

            Queue<int> list_2 = new Queue<int>(); // Обобщённая коллекция (очередь)
            list_2.Enqueue(3); list_2.Enqueue(8); list_2.Enqueue(5); list_2.Enqueue(1);
            list_2.Enqueue(7); list_2.Enqueue(3); list_2.Enqueue(10);
            Console.WriteLine("Обобщенная коллекция (очередь): ");
            foreach (object i in list_2)
            {
                Console.Write(i + "\t");
            }
            list_2.Dequeue();
            Console.WriteLine("\nНаша обновленная обобщенная коллекция: ");
            foreach (object i in list_2)
            {
                Console.Write(i + "\t");
            }


            Dictionary<int, string> list_3 = new Dictionary<int, string>(6); // Обобщённая коллекция (словарь)
            list_3.Add(1, "White"); list_3.Add(2, "Black");
            list_3.Add(3, "Forest"); list_3.Add(4, "Tree");
            list_3.Add(5, "Cat"); list_3.Add(6, "Dog");
            Console.WriteLine("\n\nОбобщенная коллекция (словарь): ");
            foreach (KeyValuePair<int, string> keyValue in list_3)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value + "   ");
            }
            string elem_1 = list_3[4];
            list_3[4] = "Sea";
            list_3.Add(7, "Wow!");
            Console.WriteLine("\nОбновленная обобщенная коллекция: ");
            foreach (KeyValuePair<int, string> keyValue in list_3)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value + "   ");
            }
            list_3.Remove(7);
            Console.WriteLine("\nОбновленная обобщенная коллекция: ");
            foreach (KeyValuePair<int, string> keyValue in list_3)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value + "   ");
            }


            Geometric_figure figure_1 = new Geometric_figure
            {
                Type_Of_Figure = "Квадрат",
                Angle_Quantity = 6,
                Square_Figure = 78,
            };
            Geometric_figure figure_2 = new Geometric_figure
            {
                Type_Of_Figure = "Круг",
                Angle_Quantity = 0,
                Square_Figure = 62,
            };
            Geometric_figure figure_3 = new Geometric_figure
            {
                Type_Of_Figure = "Трапеция",
                Angle_Quantity = 4,
                Square_Figure = 41,
            };
            Queue<Geometric_figure> list_4 = new Queue<Geometric_figure>();
            list_4.Enqueue(figure_1);
            list_4.Enqueue(figure_2);
            list_4.Enqueue(figure_3);
            Console.WriteLine("\n\n\nОбобщенная коллекция с классом (очередь): ");
            foreach (Geometric_figure i in list_4)
            {
                Console.Write(i.Type_Of_Figure + "    ");
            }
            list_4.Dequeue();
            Console.WriteLine("\nОбновленная обобщенная коллекция с классом: ");
            foreach (Geometric_figure i in list_4)
            {
                Console.Write(i.Type_Of_Figure + "    ");
            }

            Dictionary<int, Geometric_figure> list_5 = new Dictionary<int, Geometric_figure>(3);
            list_5.Add(1, figure_3);
            list_5.Add(2, figure_2);
            list_5.Add(3, figure_1);
            Console.WriteLine("\n\nНаша обобщенная коллекция с классом (словарь): ");
            foreach (KeyValuePair<int, Geometric_figure> keyValue in list_5)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value.Type_Of_Figure + "   ");
            }
            Geometric_figure elem_2 = list_5[1];
            list_5[1] = figure_1;
            list_5.Add(4, figure_2);
            Console.WriteLine("\nНаша обновленная обобщенная коллекция с классом: ");
            foreach (KeyValuePair<int, Geometric_figure> keyValue in list_5)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value.Type_Of_Figure + "   ");
            }

            list_5.Remove(4);
            Console.WriteLine("\nНаша обновленная обобщенная коллекция с классом: ");
            foreach (KeyValuePair<int, Geometric_figure> keyValue in list_5)
            {
                Console.Write(keyValue.Key + " - " + keyValue.Value.Type_Of_Figure + "   ");
            }
            Console.WriteLine("\n\n");

            ObservableCollection<Geometric_figure> list_6 = new ObservableCollection<Geometric_figure>(); // Наблюдаемая коллекция
            list_6.CollectionChanged += Collection_Changes;
            list_6.Add(figure_1);
            list_6.Add(figure_2);
            list_6.Add(figure_3);
            Console.WriteLine("\nНаша обобщенная коллекция: ");
            foreach (Geometric_figure i in list_6)
            {
                Console.Write(i.Type_Of_Figure + "    ");
            }
            Console.WriteLine("\n");

            list_6.RemoveAt(0);
            Console.WriteLine("\nНаша обновленная необобщенная коллекция: ");
            foreach (Geometric_figure i in list_6)
            {
                Console.Write(i.Type_Of_Figure + "    ");
            }
            Console.ReadKey();
        }
        private static void Collection_Changes(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Geometric_figure figure = e.NewItems[0] as Geometric_figure;
                    Console.WriteLine($"Добавлен новый объект: {figure.Type_Of_Figure}.");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Geometric_figure figure_0 = e.OldItems[0] as Geometric_figure;
                    Console.WriteLine($"Удален объект: {figure_0.Type_Of_Figure}.");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Geometric_figure figure_1 = e.OldItems[0] as Geometric_figure;
                    Geometric_figure figure_2 = e.NewItems[0] as Geometric_figure;
                    Console.WriteLine($"Объект {figure_1.Type_Of_Figure} заменён на {figure_2.Type_Of_Figure}.");
                    break;
            }
        }
    }
}
