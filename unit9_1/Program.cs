public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

try
{
}
catch (Exception e)
{
    if (e is MyCustomException)
    {
        Console.WriteLine("My Custom Exception Occurred: " + e.Message);
    }
    else if (e is InvalidOperationException)
    {
        Console.WriteLine("Invalid Operation Exception Occurred: " + e.Message);
    }
    else if (e is NullReferenceException)
    {
        Console.WriteLine("Null Reference Exception Occurred: " + e.Message);
    }
    else if (e is DivideByZeroException)
    {
        Console.WriteLine("Divide By Zero Exception Occurred: " + e.Message);
    }
    else if (e is ArgumentOutOfRangeException)
    {
        Console.WriteLine("Argument Out Of Range Exception Occurred: " + e.Message);
    }
}
finally
{
}