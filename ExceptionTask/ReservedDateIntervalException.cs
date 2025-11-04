public class WrongDateIntervalException : Exception
{
    public WrongDateIntervalException() : base("Bu tarix intervalında artıq görüş var.") { }
}

public class WrongDateIntervalExceptions: Exception
{
    public WrongDateIntervalExceptions() : base("FromDate, ToDate-dən kiçik olmalıdır.") { }
}
