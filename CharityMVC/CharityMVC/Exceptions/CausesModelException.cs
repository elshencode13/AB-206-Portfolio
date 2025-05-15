namespace CharityMVC.Exceptions
{
    public class CausesModelException : Exception
    {

        public CausesModelException():base("Default Exception Message")
        {
            
        }
        public CausesModelException(string errorMesssage): base(errorMesssage)
        {
            
        }
    }
}
