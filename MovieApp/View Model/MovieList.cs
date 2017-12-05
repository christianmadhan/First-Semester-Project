using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Model;

namespace MovieApp.View_Model
{
    class MovieList
    {
        // The collection of all the movies, the list that is displayed in the view.
        public ObservableCollection<Movie> Movies { get; set; }

        // Only accessible for the admin
        public RelayCommand AddItem { get; set; }

        // Only accessible for the admin
        public RelayCommand DeleMovie { get; set; }

        // Only accessible for the admin
        public Movie AddNewMovie { get; set; }


        // Create some movies to be in the list at the beginning of the program.
        public MovieList()
        {
            Movies = new ObservableCollection<Movie>()
            {
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\n Best movie ever"),
                new Movie("../Assets/daddyHome.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/daddyHome.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),
                new Movie("../Assets/avenger.jpg","Avengers","Martin","1:50:0","Action","Jennifor Anniston", "18+","\nBest movie ever"),

            };
        }

    }
}
