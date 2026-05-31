using System.Collections.Generic;
using System.Globalization;

namespace Lists{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int employeeNumber = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < employeeNumber; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idFinder = int.Parse(Console.ReadLine());

            Employee emp = employeeList.Find(x => x.getId() == idFinder);
            if (emp != null)
            {
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}