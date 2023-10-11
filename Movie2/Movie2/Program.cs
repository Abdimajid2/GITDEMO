namespace Movie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stars1 = { "kalle", "ahmed", "ek" };
            Movie movie0 = new Movie("pippi", " majid", new DateTime(1999,06,28), 74, false, stars1 );

            string[] stars2 = { "moahmmed", "aleksander", "sebbe" };
            Movie movie1 = new Movie("spiderman", " mattias", new DateTime(1946, 12 , 23), 85, true, stars2);

            string[] stars3 = { "salle", "sandra", "erika" };
            Movie movie2 = new Movie("No Hasta Manyana ", " dree low", new DateTime(1875, 01, 30), 106, false, stars3);


            List<Movie> movies = new List<Movie>
             {
                 movie0, movie1, movie2
             };


            foreach(Movie movie in movies)
            {
                Movie.MakingMovie(movie);
                Console.ReadKey();
            }

           

        }
    }
}