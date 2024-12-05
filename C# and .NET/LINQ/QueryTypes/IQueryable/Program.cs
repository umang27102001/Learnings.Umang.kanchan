namespace IQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var DBContext = new MyDbContext())
            {
                var moviesDelayed = DBContext.Movie.AsQueryable().Where(X => true).Select(c => c);
                var moviesImmediate = DBContext.Movie.AsQueryable().Where(movie => true).Select(movie => movie).ToList();
                var MGenre1 = new Genre { G_Name = "Drama" };
                var MPlatform1 = new Platform { P_Name = "Youtube", Fees = 131 };
                var MRating1 = new Rating { R_Certification = "B*" };
                var MyMovie1 = new Movie { M_Name = $"Tom and Tommi Endgame{new Random().Next(1, 100) + new Random().Next(1, 899)}", Release = "December 2024", Location = "India", Budget = 1235455, Cast = new List<string>() { "Moni Roi", "Captain Pakistan" }, Director = "Vikram Kanchan", Producer = "Mohan", M_Platform = MPlatform1, M_Genre = MGenre1, M_Rating = MRating1 };
                DBContext.Movie.Add(MyMovie1);
                DBContext.SaveChanges();
                foreach (var mv in moviesDelayed)
                {
                    Console.WriteLine(mv.M_Name);
                }
                Console.WriteLine("\n");
                foreach (var mv in moviesImmediate)
                {
                    Console.WriteLine(mv.M_Name);
                }
            }
        }
    }
}
