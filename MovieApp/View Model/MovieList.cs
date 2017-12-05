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
        public ObservableCollection<Movie> Movies { get; set; }

        public RelayCommand AddItem { get; set; }

        public RelayCommand DeleMovie { get; set; }

        public Movie AddNewMovie { get; set; }

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
