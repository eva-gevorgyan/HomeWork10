using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal interface ICourse:IEntity
    {
        string Name { get; set; }
        //string Description { get; set; }
        int Count { get; set; }
        //List<string> Courses { get; }
        void GenerateCourse(string a);
        void CancelCourse(string a);
        
        //void ShowCoursesList(List<string> Courses)
        //{
        //    foreach(var k in Courses)
        //    {
        //        Console.WriteLine(k);
        //    }
        //}

    }
}
