using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public struct Courses {
       private string name, degree;
       private int code;
        public Courses(string name, int code, string degree) {
            this.name = name;
            this.code = code;
            this.degree = degree;
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Degree { get { return degree; }
            set { degree = value; }
        }
        public int Code { get {return code; } set { code = value; } }
        public override string ToString()
            {

            return $"Courses : Name : {name} , Code : {code} , degree : {degree}";
        }
    }

    public struct Student { 
        
        Courses[] courses;
        public string Name { set; get; }
        public string Gender { set; get; }
        public int ID { get; set; }
        public Student(string Name,int ID,string Gender,Courses[] courses) { 
        this.courses = courses;
            this.ID = ID;
            this.Gender = Gender;
            this.Name = Name;
        }

        public string this[int index]
        {
            get {
                for (int i = 0; i < courses.Length; i++)
                {
                    if (courses[i].Code == index)
                    {
                        return courses[i].ToString();
                    }
                   
                }
                 return "Course not found";

            }
            set {
                for (int i = 0; i < courses.Length; i++)
                {
                    courses[i].Name = value;
                }
            }
        }

    }


        internal class Program
        {

        static void display(Courses[] p) {
            foreach (Courses s in p) {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
            {
            Courses[] s = {
            new Courses("Arabic",12,"A+"),
            new Courses ("Math",17,"B+"),
            new Courses("Programing",122,"C"),
            new Courses("Electronics",147,"A")
            };

            display(s);

            Console.WriteLine();
            Console.WriteLine("=-----------------=");
            Student st = new Student("Ebrahim", 15, "Male", s);
            Console.WriteLine(st[12]);
            Console.WriteLine(st[14]);

                Console.ReadLine();
            }
        }
    }
