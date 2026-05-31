namespace Arrays
{
    internal class Student
    {
        private string _name;
        private string _email;

        public Student(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public override string ToString()
        {
            return _name + ", " + _email;
        }
    }
}
