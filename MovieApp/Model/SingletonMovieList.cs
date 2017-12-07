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
                new Movie("../Assets/strange.jpg", "Doctor Strange", "Ron Howard", "1:34:0", "Action", "Bennidict Boi", "15+",
                    "\nBest movie ever"),
                new Movie("../Assets/avatar.jpg", "Avatar", "Phil Lord", "1:23:0", "Action", "Jennifor Anniston",
                    "15+", "\nBest movie ever"),
                new Movie("../Assets/intersteller.jpg", "Intersteller", "Martin Scorsese", "1:27:0", "Action", "Jennifor Anniston",
                    "15+", "\nBest movie ever"),
                new Movie("../Assets/kingsman.jpg", "Kingsmen", "Christopher Nolan", "1:52:0", "Action", "Jennifor Anniston", "15+",
                    "\nBest movie ever"),
                new Movie("../Assets/Logan.jpg", "Logan", "Ron Howard", "2:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/nutJob2.jpg", "Nut Job 2", "Lawernce Kasdan", "1:16:0", "Action", "Jennifor Anniston", "PG",
                    "\nBest movie ever"),
                new Movie("../Assets/wonder.jpg", "Wonder", "James Cameron", "1:33:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/insideOut.jpg", "Inside Out", "Martin Scorsese", "1:10:0", "Action", "Jennifor Anniston", "PG",
                    "\nBest movie ever"),
                new Movie("../Assets/galaxy.jpg", "Gaurdians Galaxy", "Ron Howard", "2:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/batman1.jpg", "Batman", "Martin", "1:41:0", "Action", "Jennifor Anniston", "PG",
                    "\nBest movie ever"),
                new Movie("../Assets/bringHimHome.jpg", "The Martian", "Chris Miller", "1:50:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/ninjago.jpg", "Ninjago", "Martin Scorsese", "2:50:0", "Action", "Jennifor Anniston", "PG",
                    "\nBest movie ever"),
                new Movie("../Assets/thor1.jpg", "Thor", "Ron Howard", "1:43:0", "Action", "Jennifor Anniston", "18+",
                    "\nBest movie ever"),
                new Movie("../Assets/superMan1.jpg", "Superman", "Lawernce Kasdan", "1:34:0", "Action", "Jennifor Anniston", "15+",
                    "\nBest movie ever"),
                new Movie("../Assets/missionImpossible.jpg", "Mission Impossible", "Chris Miller", "1:14:0", "Action", "Jennifor Anniston", "15+",
                    "\nBest movie ever"),
                new Movie("../Assets/murderOnTheOrientExpress.jpg", "Phil Lord", "James Cameron", "2:12:0", "Action", "Jennifor Anniston", "15+",
                    "\nBest movie ever"),
                new Movie("../Assets/paddignton2.jpg", "Paddington", "Martin Scorsese", "2:20:0", "Action", "Jennifor Anniston", "PG",
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
