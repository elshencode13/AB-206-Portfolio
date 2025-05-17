namespace CompanyApp
{
    // Custom Exception
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message) { }
    }
}
