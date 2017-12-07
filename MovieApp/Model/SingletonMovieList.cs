using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    class SingletonMovieList
    {
        public static ObservableCollection<Movie> ListMovie;

        private static SingletonMovieList Instance { get; set; }

        private SingletonMovieList()
        {
            ListMovie = new ObservableCollection<Movie>()
            {
                new Movie("../Assets/justiceLeague.jpg","Justice League","Martin","1:10:0","Action","Jennifor Anniston", "18+","\n Best movie ever"),
                new Movie("../Assets/daddyHome.jpg","Daddys Home 2","Martin","1:34:0","Comedy","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/dragon2.jpg","Train Your Dragon","Martin","1:54:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/paddignton2.jpg","Forrest Gump","Martin","2:04:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/superman.jpg","Superman","Martin","1:23:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/thor.jpg","Thor","Martin","1:45:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/SpiderMan.jpg","Spiderman","Martin","2:40:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/batman.jpg","Lego Batman","Martin","1:30:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/bringHimHome.jpg","The Martian","Martin","1:33:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/galaxy.jpg","Gaurdians Galaxy","Martin","1:23:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/insideOut.jpg","Inside Out","Martin","2:22:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/intersteller.jpg","Intersteller","Martin","2:48:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/kingsman.jpg","Kingsmen","Martin","1:60:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/Logan.jpg","Logan","Martin","1:29:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/ninjago.jpg","Ninjago","Martin","1:58:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/wonder.jpg","Wonder","Martin","2:03:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/nutJob2.jpg","Nut Job 2","Martin","1:34:0","Comedy","Jennifor Anniston", "18+","\nBest movie ever"),

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
