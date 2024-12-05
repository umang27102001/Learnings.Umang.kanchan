namespace AmLite.Abstractions.Result.RepositoryResult
{
    using AmLite.Abstractions.Result.RepositoryResult.Interfaces;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents a Repository result.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class RepositoryOneResult<TResource> : RepositoryResult, IRepositoryOneResult<TResource>
    {
        /// <summary>
        /// Represents the resource contained in the Result.
        /// </summary>
        public TResource Resource { get; set; }

        /// <summary>
        /// Gets and sets a value indicating if the result is available.
        /// </summary>
        public bool HasResource { get; set; }
    }
}