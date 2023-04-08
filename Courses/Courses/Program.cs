namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registration person1 = new Registration("FirstName1", "LastName1", "example@gmail.com");
            person1.CreateID();
            person1.GenerateCourse("SMM");
            person1.GenerateCourse("PHP");
            person1.GenerateCourse("JavaScript");
            person1.GenerateCourse("CSharp");
            Console.WriteLine();
            person1.ShowCoursesList();
            Console.WriteLine();
            person1.CancelCourse("SMM");
            Console.WriteLine();
            person1.ShowCoursesList();
            Console.WriteLine();
            person1.GetStudents();
        }
    }
}