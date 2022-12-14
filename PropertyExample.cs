using System;
namespace projects
{
    public class Employee
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class PropertyExample
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Amruth Reddy";
            Console.WriteLine("Employee Name: " + e1.Name);

        }
    }
}

