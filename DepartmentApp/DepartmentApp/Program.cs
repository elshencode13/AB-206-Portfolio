using System;

namespace CompanyApp
{

    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Department department = new Department("Software", 2);

                Employee emp1 = new Employee("Elvin", 27, 1500);
                Employee emp2 = new Employee("Nigar", 30, 1800);
                Employee emp3 = new Employee("Tural", 35, 2000);

                department.AddEmployee(emp1);
                department.AddEmployee(emp2);

                // Bu addımda exception atılacaq
                department.AddEmployee(emp3);

                department.ShowAllEmployees();

                Console.WriteLine("Access by index:");
                Console.WriteLine(department[0]);

                // Indexer vasitəsilə dəyişiklik:
                department[0] = new Employee("Yusif", 29, 1900);
                Console.WriteLine("Updated Employee:");
                Console.WriteLine(department[0]);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
        }
    }
}
