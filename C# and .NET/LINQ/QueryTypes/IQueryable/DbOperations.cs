namespace IQueryable
{
    public class DbOperations
    {
        public void SaveData()
        {

            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();
                var MGenre1 = new Genre { G_Name = "Sci-Fi" };
                var MPlatform1 = new Platform { P_Name = "Amazon Prime", Fees = 101 };
                var MRating1 = new Rating { R_Certification = "A*" };
                var MyMovie1 = new Movie { M_Name = "Avengers Endgame", Release = "December 2022", Location = "India", Budget = 123455, Cast = new List<string>() { "Tony Stark", "Captain Africa" }, Director = "Umang Kanchan", Producer = "Tarun", M_Platform = MPlatform1, M_Genre = MGenre1, M_Rating = MRating1 };
                context.Movie.Add(MyMovie1);
                var MGenre2 = new Genre { G_Name = "Drama" };
                var MPlatform2 = new Platform { P_Name = "Netflix", Fees = 161 };
                var MRating2 = new Rating { R_Certification = "A*" };
                var MyMovie2 = new Movie { M_Name = "Tarjan", Release = "December 2012", Location = "India", Budget = 123456, Cast = new List<string>() { "Virat kohli", "Rohit Dholi" }, Director = "Tarun Singh", Producer = "Varun", M_Platform = MPlatform2, M_Genre = MGenre2, M_Rating = MRating2 };
                context.Movie.Add(MyMovie2);
                var MGenre3 = new Genre { G_Name = "Sci-Fi" };
                var MPlatform3 = new Platform { P_Name = "Cinema ", Fees = 201 };
                var MRating3 = new Rating { R_Certification = "A*" };
                var MyMovie3 = new Movie { M_Name = "Avatar", Release = "December 2023", Location = "America", Budget = 3323455, Cast = new List<string>() { "Rohan singh", "Captain Africa" }, Director = "Varun singh", Producer = "Karun", M_Platform = MPlatform3, M_Genre = MGenre3, M_Rating = MRating3 };
                context.Movie.Add(MyMovie3);
                var MGenre4 = new Genre { G_Name = "Drama" };
                var MPlatform4 = new Platform { P_Name = "Amazon Prime", Fees = 101 };
                var MRating4 = new Rating { R_Certification = "A*" };
                var MyMovie4 = new Movie { M_Name = "Avengers Infinitywars", Release = "December 2022", Location = "New Zealand", Budget = 123458, Cast = new List<string>() { "Tony Stark", "Captain Pakistan" }, Director = "Umang Kanchan", Producer = "Tarun", M_Platform = MPlatform4, M_Genre = MGenre4, M_Rating = MRating4 };
                context.Movie.Add(MyMovie4);
                context.SaveChanges();
            }

        }

    }
}
