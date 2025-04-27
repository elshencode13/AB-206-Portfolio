namespace task_1;

    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                int password = Convert.ToInt32(Console.ReadLine());

                User user = new User(name, surname, age, username, password);
                user.ShowFullData();
                user.GetFullName();

            
        }
    }
