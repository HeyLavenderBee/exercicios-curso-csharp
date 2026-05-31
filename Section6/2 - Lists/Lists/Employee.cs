using System.Globalization;

namespace Lists
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public int getId()
        {
            return _id;
        }

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            _salary += _salary * (percentage/100);
        }

        public override string ToString()
        {
            return _id+", "+_name+", "+_salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
