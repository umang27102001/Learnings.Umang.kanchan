namespace AmLite.Abstractions.Result.RepositoryResult
{
    using AmLite.Abstractions.Result.RepositoryResult.Interfaces;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents a Repository result.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class RepositoryResult : IRepositoryResult
    {
        /// <summary>
        /// Gets a value indicating whether or not error occured.
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// Gets a value representing the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the result is recoverable. 
        /// </summary>
        public bool IsRecoverable { get; set; }

        /// <summary>
        /// Gets a value representing the number of attempts.
        /// </summary>
        public int Attempts { get; set; }

        /// <summary>
        /// Gets a value representing the number of resources modified.
        /// </summary>
        public long Modified { get; set; }

        /// <summary>
        /// Gets a value indicating wheter or not the result is acknowledged.
        /// </summary>
        public bool Acknowledged { get; set; }
    }
}