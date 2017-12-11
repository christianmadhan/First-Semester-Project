using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
  public  class singletonMovie
    {
        public static Movie _movie;

        private static singletonMovie Instance { get; set; }

        private singletonMovie()
        {
            _movie = new Movie();
        
        }

        public static singletonMovie GetInstance()
        {
            if (Instance == null)
            {
                Instance = new singletonMovie();
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

        public int GetPrice()
        {
            return _movie.Price;
        }

        public Uri GetTrailer()
        {
            return _movie.Trailer;
        }
    }
}
