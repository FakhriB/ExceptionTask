
namespace ExceptionTask
{
    [Serializable]
    internal class WrongDateException : Exception
    {
        public WrongDateException()
        {
        }

        public WrongDateException(string? message) : base(message)
        {
        }

        public WrongDateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}