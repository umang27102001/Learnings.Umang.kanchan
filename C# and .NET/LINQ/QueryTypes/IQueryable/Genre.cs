
namespace IQueryable
{
    using System.ComponentModel.DataAnnotations;
    public class Genre
    {
        [Key]
        public int G_Id { get; set; }
        public string G_Name { get; set; }

    }
}
