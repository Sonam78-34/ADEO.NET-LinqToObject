namespace LinqToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeedetail = from employee in Employee.GetEmployeedetail()
                                 orderby employee.name
                                 select employee;
            foreach (var item in employeedetail)
            {
                Console.WriteLine(item.Id +" "+item.name+" "+item.job);
            }

            Console.WriteLine(" ");
            var employeedetail2 = from employee in Employee.GetEmployeedetail()
                                 orderby employee.name descending
                                 select employee;
            foreach (var item in employeedetail2)
            {
                Console.WriteLine(item.Id + " " + item.name + " " + item.job);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Elementary level function");

            //ElementAt()
            var employeethird= Employee.GetEmployeedetail().ElementAt(2);
            Console.WriteLine(employeethird.name+" "+employeethird.job);



            //ElementAtOrDefault
            var emp1= Employee.GetEmployeedetail().ElementAt(3);
            var emp2= Employee.GetEmployeedetail().ElementAt(0);
            Console.WriteLine(emp2.name+" "+ emp2.Id);
            Console.WriteLine(emp1);



            //First()
            var emp3= Employee.GetEmployeedetail().First();

            Console.WriteLine("First function "+emp3.name);



            //FirstOrDefault
            var emp4= Employee.GetEmployeedetail().FirstOrDefault(j=>j.job=="Doctor");
            Console.WriteLine("First or default "+emp4.name+emp4.job);

            //last()
            var emp5 = Employee.GetEmployeedetail().Last();
            Console.WriteLine("The last value of emplyoee " + emp4.name + emp4.job);




            //LastOrDefault()

            var emp6 = Employee.GetEmployeedetail().LastOrDefault(j => j.name == "Sonam");
            Console.WriteLine("LastOrDefault " + emp4.name + emp4.job);


            //













            //LinQToObject
            string[] namerArry = { "sonam", "Riya", "siya" };
            IEnumerable<string> name = from studname in namerArry
                                       where studname.Contains("sonam")
                                       select studname;
            foreach( string studname in name)
            {
                Console.WriteLine(studname);
            }
        }
    }
}