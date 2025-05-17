namespace CompanyApp
{
    // Department class
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        private Employee[] Employees;
        private int currentCount = 0;

        public Department(string name, int employeeLimit)
        {
            if (string.IsNullOrWhiteSpace(name) || employeeLimit <= 0)
                throw new ArgumentException("Department information is invalid");

            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[employeeLimit];
        }

        public void AddEmployee(Employee employee)
        {
            if (currentCount >= EmployeeLimit)
                throw new CapacityLimitException("Employee limit reached!");

            Employees[currentCount++] = employee;
        }

        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index >= currentCount)
                    throw new IndexOutOfRangeException("Invalid index");
                return Employees[index];
            }
            set
            {
                if (index < 0 || index >= currentCount)
                    throw new IndexOutOfRangeException("Invalid index");
                Employees[index] = value;
            }
        }

        public void ShowAllEmployees()
        {
            for (int i = 0; i < currentCount; i++)
            {
                Console.WriteLine(Employees[i]);
                Console.WriteLine("----------------------");
            }
        }
    }
}
