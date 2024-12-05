
namespace IQueryable
{
    using System.ComponentModel.DataAnnotations;
    public class Rating
    {
        [Key]
        public int R_Id { get; set; }
        public string? R_Certification { get; set; }
    }
}
