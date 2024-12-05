namespace EntityFramework.Models
{
    /// <summary>
    /// Represents a location of aM office
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Primary key of a location in database
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
