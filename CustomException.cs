public class CustomException : Exception
{
    private const string defaultMessage = "An Error Occured!";

    public CustomException() : base(defaultMessage)
    {

    }

    public CustomException(string message) : base(message)
    {
        
    }

    public CustomException(Exception innerException) : base(defaultMessage, innerException)
    {

    }
}
