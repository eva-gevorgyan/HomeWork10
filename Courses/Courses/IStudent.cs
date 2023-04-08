using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal interface IStudent:IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
       // List<string> Courses { get; }
    }
}
