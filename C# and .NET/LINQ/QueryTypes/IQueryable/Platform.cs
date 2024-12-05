
namespace IQueryable
{
    using System.ComponentModel.DataAnnotations;
    public class Platform
    {
        [Key]
        public int P_Id { get; set; }
        public string P_Name { get; set; }
        public double Fees { get; set; }
    }
}
