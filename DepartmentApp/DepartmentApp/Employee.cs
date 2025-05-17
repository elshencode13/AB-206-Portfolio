namespace CompanyApp
{
    // Employee class
    public class Employee : IPerson
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            if (string.IsNullOrWhiteSpace(name) || age <= 0 || salary <= 0)
                throw new ArgumentException("Employee information is invalid");

            Id = ++_idCounter;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nSalary: {Salary} AZN";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
