namespace AmLite.Api.Middleware
{
    using AmLite.Repository.DbContexts;
    using AmLite.Repository.Models;
    using Microsoft.AspNetCore.Http;

    public class AddMasterDataMiddleware
    {
        private readonly RequestDelegate _next;

        public AddMasterDataMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context, AmDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (!dbContext.Divisions.Any())
            {
                // Projects
                var p1 = new Project { Name = "Am.EEQ-Conquest" };
                var p2 = new Project { Name = "Am.EEQ-Export" };
                var p3 = new Project { Name = "Am.AVG.Ingest" };
                var p4 = new Project { Name = "Am.AVG.Private" };
                var p5 = new Project { Name = "Am.IMC.Private" };
                var p6 = new Project { Name = "Am.Campaign.Ingestion" };
                var p7 = new Project { Name = "Am.DataPlatform" };
                var p8 = new Project { Name = "Am.AOM" };

                // Locations
                var l1 = new Location { Name = "Gurgaon" };
                var l2 = new Location { Name = "Noida" };
                var l3 = new Location { Name = "Banglore" };

                // Department
                var d1 = new Division()
                {
                    Name = "Software Development",
                    Teams = new List<Team>
                    {
                        new Team{
                            TeamName ="Interstellar",
                            ProjectList  = new List<Project>
                            {
                                p1,p2,p3,p4
                            },
                            Location = l1
                        },
                        new Team{
                            TeamName ="Discovery",
                            ProjectList  = new List<Project>
                            {
                                p6
                            },
                            Location = l2
                        },
                        new Team{
                            TeamName ="Apollo",
                            ProjectList  = new List<Project>
                            {
                                p5,p8
                            },
                            Location = l1
                        }
                     },

                };
                var d2 = new Division()
                {
                    Name = "Data Engineering",
                    Teams = new List<Team>
                    {
                        new Team{
                            TeamName ="Data Chronicals",
                            ProjectList  = new List<Project>
                            {
                                p7
                            },
                            Location = l2
                        },
                        new Team{
                            TeamName ="Numpy",
                            ProjectList  = new List<Project>
                            {
                                p1,p5
                            },
                            Location = l1
                        },
                        new Team{
                            TeamName ="AlphaInsights",
                            ProjectList  = new List<Project>
                            {
                                p2,p8
                            },
                            Location = l2
                        }
                     },
                };
                // Roles
                var r1 = new Role { RoleName = "Software Engineer" };
                var r2 = new Role { RoleName = "Quality Engineer" };
                var r3 = new Role { RoleName = "Intern Software Engineer" };
                var r4 = new Role { RoleName = "Intern Data Engineer" };
                var r5 = new Role { RoleName = "Data Engineer" };
                var r6 = new Role { RoleName = "Devops Engineer" };
                var r7 = new Role { RoleName = "Product Owner" };

                // Add to db
                dbContext.Roles.Add(r1);
                dbContext.Roles.Add(r2);
                dbContext.Roles.Add(r3);
                dbContext.Roles.Add(r4);
                dbContext.Roles.Add(r5);
                dbContext.Roles.Add(r6);
                dbContext.Roles.Add(r7);
                dbContext.Divisions.Add(d1);
                dbContext.Divisions.Add(d2);

                await dbContext.SaveChangesAsync();
            }
            await this._next(context);
        }
    }
}
