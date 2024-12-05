namespace AmLite.Repository.Models
{
    using System.Diagnostics.CodeAnalysis;
    /// <summary>
    /// Represents a location of aM office
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Location
    {
        /// <summary>
        /// Id of a location
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// NAme of the location
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Reference navigation to Division entity
        /// </summary>
        public List<Division> Divisions { get; set; }
    }
}