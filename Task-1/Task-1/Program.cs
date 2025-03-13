#region Task-1
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            Console.Write("Bir eded daxil edin:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool exist = true;

            foreach (int number in numbers)
            {
                if (number < num)
                {
                    Console.WriteLine(exist);
                    break;
                }
                else
                {
                    Console.WriteLine(!exist);
                    break;
                }
            }
        }
    }
}
#endregion
#region Task-2
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25, };

            int big = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] < array[i])
                {
                    big = array[i];

                }
            }
            Console.WriteLine(big);
        }
    }
}
#endregion
#region Task-3
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Polidrom bir eded daxil edin: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int qaliq;
        int sum = 0;
        while (number != 0)
        {
            qaliq = number % 10;
            sum = sum * 10 + qaliq;
            number -= qaliq;
            number /= 10;


        }
        Console.WriteLine(sum);

    }
}

#endregion
#region Task-4
namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Polidrom bir eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                int qaliq = num % 10;
                sum = sum * 10 + qaliq;
                num -= qaliq;
                num /= 10;

                if (num == sum)
                {
                    Console.WriteLine("Bu eded polidromdur.");
                    break;
                }
                else
                {
                    Console.WriteLine("Bu eded polidromd deyil.");
                    break;
                }
            }

        }
    }
}
#endregion
#region Task-5
namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            // int num = 0;

            while (number > 0)
            {
                int num = number % 10;
                sum *= num;
                number /= 10;


            }
            Console.Write(sum);

        }
    }
}
#endregion
#region Task-6
namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Murekkeb ededir");
                    break;
                }
                else
                {
                    Console.WriteLine("Sade ededir");
                }

            }

        }
    }
}
#endregion
#region Task-7
namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adi daxil edin: ");
            string soz = Console.ReadLine();

            string[] array = { "vaqif", "arif", "david" };

            for (int i = 0; i < array.Length; i++)
            {
                if (soz == array[i])
                {
                    Console.WriteLine("Soz massivde var");
                }
            }

        }
    }
}
#endregion
#region Task-8
namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Herfi daxil edin: ");
            char herf = Console.ReadLine();

            string[] array = { "vaqif", "arif", "david" };

            for (int i = 0; i < array.length; i++)
            {
                if (herf == array[i])
                {
                    Console.WriteLine("Herf massivde var");
                }
            }


        }
    }
}

#endregion
#region Task-9
namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "vaqif", "arif", "faiq" };
            bool xeta = false;
            string sozunters = "";
            for (int i = 0; i < array.Length - 1; i--)
            {
                if (!xeta)
                {
                    sozunters += array[i];
                }
            }
            Console.WriteLine(sozunters);
        }
    }
}
#endregion