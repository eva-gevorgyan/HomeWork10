using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class Registration : ICourse, IStudent
    {
        public string Name { get; set; }
       // public string Description { get ; set; }
        public int Count { get; set; }

        public List<string> Students =new List<string>();
        public int StudentCount { get; set; }

        public int ID { get ; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Email { get ; set ; }
        public void CreateID()
        {
            Random rnd = new Random();
            ID = rnd.Next();
            Console.WriteLine($"Your ID is: {ID}");
        }
        public Registration(string FirstName,string LastName,string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            StudentCount++;
            Students.Add(FirstName);
        }
        public List<string> Courses=new List<string>();
        public void GenerateCourse(string a)
        {
            switch (a)
            {
                case ("SMM"):
                    Console.WriteLine("You choose " + ((Courses_List)0));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("CSharp"):
                    Console.WriteLine("You choose " + ((Courses_List)1));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("PM"):
                    Console.WriteLine("You choose " + ((Courses_List)2));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("PHP"):
                    Console.WriteLine("You choose " + ((Courses_List)3));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("JavaScript"):
                    Console.WriteLine("You choose " + ((Courses_List)4));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("HTML"):
                    Console.WriteLine("You choose " + ((Courses_List)5));
                    Courses.Add(a);
                    Count++;
                    break;
                case ("CSS"):
                    Console.WriteLine("You choose " + ((Courses_List)6));
                    Courses.Add(a);
                    Count++;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        public void CancelCourse(string a)
        {
            Courses.Remove(a);
            Count--;
            Console.WriteLine($"Canceled {a}\nNow you have {Count} courses:");
        }
        public void ShowCoursesList()
        {
            Console.WriteLine("Your Courses");
            foreach(var k in Courses)
            {
                Console.WriteLine(k);
            }
        }
        public void GetStudents()
        {
            Console.WriteLine($"We have {StudentCount} students");
            foreach (var k in Students)
            {
                Console.WriteLine(k);
            }
        }
    }
    enum Courses_List
    {
        SMM,
        CSharp,
        PM,
        PHP,
        JavaScript,
        HTML,
        CSS
    }
}
