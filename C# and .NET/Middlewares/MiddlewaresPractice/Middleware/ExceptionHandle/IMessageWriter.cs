namespace MiddlewaresPractice.Middleware.ExceptionHandle
{
    /// <summary>
    /// A contract to expose the implementation of Writer(string message) method.
    /// </summary>
    public interface IMessageWriter
    {
        void Writer(string message);
    }
}
