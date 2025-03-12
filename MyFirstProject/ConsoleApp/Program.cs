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