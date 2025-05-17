namespace CompanyApp
{
    // Interface
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string ShowInfo();
    }
}
