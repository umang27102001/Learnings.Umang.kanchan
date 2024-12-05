namespace AmLite.Abstractions.Result.RepositoryResult.Interfaces
{
    /// <summary>
    /// Defines methods and properties to implement result of a repository.
    /// </summary>
    public interface IRepositoryResult
    {
        /// <summary>
        /// Gets a value indicating whether or not error occured.
        /// </summary>
        public bool IsError { get; }

        /// <summary>
        /// Gets a value representing the error message.
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// Gets a value indicating whether or not the result is recoverable. 
        /// </summary>
        public bool IsRecoverable { get; }

        /// <summary>
        /// Gets a value representing the number of attempts.
        /// </summary>
        public int Attempts { get; }

        /// <summary>
        /// Gets a value representing the number of resources modified.
        /// </summary>
        public long Modified { get; }

        /// <summary>
        /// Gets a value indicating wheter or not the result is acknowledged.
        /// </summary>
        public bool Acknowledged { get; }

    }
}
