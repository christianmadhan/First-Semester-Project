using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
   public class SingletonMovieList
    {
        public static ObservableCollection<Movie> ListMovie;

        private static SingletonMovieList Instance { get; set; }

        private SingletonMovieList()
        {
            ListMovie = new ObservableCollection<Movie>()
            {
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\n Best movie ever"),
                new Movie("../Assets/daddyHome.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston",
                    "18+", "\nBest movie ever"),
                new Movie("../Assets/daddyHome.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston",
                    "18+", "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/avenger.jpg", "Avengers", "Martin", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),

            };
        }

        public static SingletonMovieList GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonMovieList();
            }
            return Instance;
        }

        public void SetMovieList(ObservableCollection<Movie> listMovie)
        {
            ListMovie = listMovie;

        }

        public ObservableCollection<Movie> GetMovieList()
        {
            return ListMovie;

        }
    }
}
