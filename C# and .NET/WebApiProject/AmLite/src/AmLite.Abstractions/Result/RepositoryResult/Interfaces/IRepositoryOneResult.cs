namespace AmLite.Abstractions.Result.RepositoryResult.Interfaces
{
    /// <summary>
    /// Defines properties and methods to implement a repository result containing a specifies resource
    /// </summary>
    /// <typeparam name="TResource">
    /// Specified resource
    /// </typeparam>
    public interface IRepositoryOneResult<out TResource> : IRepositoryResult
    {
        // <summary>
        /// Represents the resource contained in the Result.
        /// </summary>
        public TResource Resource { get; }

        /// <summary>
        /// Gets and sets a value indicating if the result is available.
        /// </summary>
        public bool HasResource { get; }
    }
}