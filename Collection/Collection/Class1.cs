using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Collection
{
    public class Salaries : IComparable<Salaries>, IComparer<Salaries>
    {
        public short salary;
        public string person;
        private string[] names = new string[10]
        {
            "Masha", "Nadya", "Kate", "Alina", "Nastya", "Braun", "John", "Misha", "Vlad", "Sonya"
        };

        public Salaries()
        {
            Random random = new Random();
            Thread.Sleep(10);
            this.salary = (short)random.Next(50, 2000);
            this.person = names[random.Next(0, 10)];
        }

        public int Compare(Salaries st1, Salaries st2)
        {
            return st2.CompareTo(st1);
        }

        public int CompareTo(Salaries salaries)
        {
            if (salaries == null)
            {
                return 1;
            }
            else
            {
                if (this.salary > salaries.salary)
                {
                    return 1;
                }
                else if (this.salary < salaries.salary)
                {
                    return -1;
                }
                else
                {
                    return this.person.CompareTo(salaries.person);
                }
            }
        }
    }
}