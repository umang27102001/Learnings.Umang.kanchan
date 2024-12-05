
namespace IQueryable
{
    using System.ComponentModel.DataAnnotations;
    public class Movie
    {
        [Key]
        public int M_Id { get; set; }
        public string M_Name { get; set; }
        public string Release { get; set; }
        public string Location { get; set; }
        public double Budget { get; set; }
        public List<String> Cast { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public int PlatformId { get; set; }
        public int GenreID { get; set; }
        public int RatingID { get; set; }
        public Platform M_Platform { get; set; }
        public Genre M_Genre { get; set; }
        public Rating M_Rating { get; set; }
        public Movie()
        {
            Cast = new List<String>();
        }
    }
}
