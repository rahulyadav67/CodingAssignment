using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssignment1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string TeamName { get; set; }

        public void Print()
        {
            Console.WriteLine("First Name:"+FirstName+ "  Last Name:" + LastName + "  Age:"+ Age +"  Gender:"+ Gender + "  Team Name:"+ TeamName);
        }

    }
}
