namespace MiddlewaresPractice.Middleware.ExceptionHandle
{
    public class MessageWriter : IMessageWriter
    {
        private readonly ILogger<MessageWriter> logger;

        public MessageWriter(ILogger<MessageWriter> logger)
        {
            this.logger = logger;
        }

        public void Writer(string message)
        {
            logger.LogInformation(message);
        }
    }
}
