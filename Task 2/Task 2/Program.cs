namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Msi", 1, 2000,32);




            notebook.GetFullInfo();
            notebook.ShowFullData();
        }
    }
}