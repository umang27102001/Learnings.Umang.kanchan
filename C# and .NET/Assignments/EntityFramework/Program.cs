using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var dbContext = new AmmDbContext())
            {
                var newRole = new Role { RoleName = "System Analyst" };
                var role= dbContext.Roles.First(e=>e.RoleName== "Software Engineer");
                var umang = new Employee { Name = "Umang Kanchan", Address = "Bareilly, Uttar Pradesh", Email = "kanchan.umang@gmail.com", Phone = "7906489858", Role = newRole, TeamId = 1, Salary = 123456789 };
                var piyush = new Employee { Name = "Piyush Chauhan", Address = "Banaras, Uttar Pradesh", Email = "chauhan.piyush@gmail.com", Phone = "8906409858", Role=role, TeamId = 2, Salary = 12356789 };
                dbContext.Add(umang);
                dbContext.Add(piyush);
                dbContext.SaveChanges();
            }
        }
    }
}
