using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string job { get; set; }

        public static List<Employee> GetEmployeedetail()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee { Id = 15, name="Saurav", job ="Software Engineering"},
                new Employee { Id = 16, name="Sona", job ="Software Engineering"},
                new Employee { Id = 15, name="Sia", job ="Doctor"}
            };
            return emplist;


        }
    }
}
