using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    class Singleton
    {
        public static Movie _movie;

        private static Singleton Instance { get; set; }

        private Singleton()
        {
            _movie = new Movie();
        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public void SetMovie(Movie movie)
        {
            _movie = movie;
        }

        public string GetImageUrl()
        {
            return _movie._imageUrl;
        }

        public string GetTitle()
        {
            return _movie.Title;
        }

        public string GetDirector()
        {
            return _movie.Director;
        }

        public string GetLength()
        {
            return _movie.Length;
        }

        public string GetActors()
        {
            return _movie.Actors;
        }

        public string GetCensorship()
        {
            return _movie.Censorship;
        }

        public string GetDescription()
        {
            return _movie.Description;
        }

        public string GetGenre()
        {
            return _movie.Genre;
        }
    }
}
