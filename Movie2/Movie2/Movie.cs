using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie2
{
    internal class Movie
    {
        public string MovieName;
        public string Director { get; set; }

        public DateTime Realisedate { get; set; }

        public int LenghtInMinutes { get; set; }

        public bool SuitableForChildren { get; set; }

        public string[] Stars { get; set; }


        public Movie(string moviename, string director, DateTime realisedate, int lenghtinminutes, bool suitableforkids, string[] stars)
        {
            MovieName = moviename;
            Director = director;
            Realisedate = realisedate;
            LenghtInMinutes = lenghtinminutes;
            SuitableForChildren = suitableforkids;
            Stars = stars;







        }

       
        public static void MakingMovie(Movie movie)
        {
            Console.Write(movie.MovieName + " är en film som har regisserats av " + movie.Director
                              + " med premiär " + movie.Realisedate.ToString("d")
                              + " och är " + movie.LenghtInMinutes + " minuter lång "
                              + ", skådespelarna i filmen är");

            for (int i = 0; i < movie.Stars.Length; i++)
            {
                if (i < movie.Stars.Length - 1)
                {
                    Console.Write(movie.Stars[i] + " , ");
                }
                else
                {
                    Console.Write(movie.Stars[i] + " . ");
                }
            }

            Console.WriteLine("filmen är " + (movie.SuitableForChildren ? " lämlig för barn" : " inte lämplig för barn "));

        }

    }

}
