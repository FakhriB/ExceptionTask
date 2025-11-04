
[Serializable]
internal class ReservedDateIntervalException : Exception
{
    public ReservedDateIntervalException()
    {
    }

    public ReservedDateIntervalException(string? message) : base(message)
    {
    }

    public ReservedDateIntervalException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}