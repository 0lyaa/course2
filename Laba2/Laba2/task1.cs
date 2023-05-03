using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class task1
    {
        static List<Student> Students = new List<Student>();
        public static void FromTxtToList(List<Student> list)
        {

            string directory = Directory.GetCurrentDirectory();
            string path = directory[0..(directory.Length - 17)] + @"\students.txt";
            if (File.Exists(path))
            {
                string s;
                using (StreamReader sw = File.OpenText(path))
                {
                    while ((s = sw.ReadLine()) != null)
                    {
                        string[] data = s.Split(',');
                        string[] name = data[0].Split(" ");
                        list.Add(new Student(name[2], name[1], name[0], int.Parse(data[1])));

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
            FromTxtToList(Students);
            var Bigger = Students.FindAll(a => a.Mark > 8);

            foreach (var item in Bigger)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Student
    {
        string Name;
        string Surname;
        string LastName;
        public int Mark;
        public Student(string name, string surname, string lastname, int mark)
        {
            Name = name;
            Surname = surname;
            LastName = lastname;
            Mark = mark;
        }
        public override string ToString()
        {
            return LastName + " " + Name + " " + Surname + " " + Mark;
        }
    }
}