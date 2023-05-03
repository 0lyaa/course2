using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba2.task3;

namespace Laba2
{
    internal class task2
    {
        static List<Employee> Employees = new List<Employee>();
        public static void FromTxtToList(List<Employee> list)
        {

            string directory = Directory.GetCurrentDirectory();
            string path = directory[0..(directory.Length - 17)] + @"\employees.txt";
            if (File.Exists(path))
            {
                string s;
                using (StreamReader sw = File.OpenText(path))
                {
                    while ((s = sw.ReadLine()) != null)
                    {
                        string[] data = s.Split(',');
                        string[] name = data[0].Split(" ");
                        list.Add(new Employee(name[2], name[1], name[0], int.Parse(data[1]), int.Parse(data[2])));

                    }
                }
            }
            else
            {
                Console.WriteLine("все погано");
            }
        }
        public static void DO()
        {
            FromTxtToList(Employees);
            Employees.Sort((a, b) => a.Salary.CompareTo(b.Salary));

            foreach (var item in Employees)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Employee
    {
        string Name;
        string Surname;
        string LastName;
        public int Salary;
        int Experience;
        public Employee(string name, string surname, string lastname, int salary, int experience)
        {
            Name = name;
            Surname = surname;
            LastName = lastname;
            Salary = salary;
            Experience = experience;
        }
        public override string ToString()
        {
            return LastName + " " + Name + " " + Surname + " " + Salary + " " + Experience;
        }
    }
}