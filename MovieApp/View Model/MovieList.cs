using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Model;

namespace MovieApp.View_Model
{
    class MovieList : NotifyChanged
    {
        private Movie _selectedMovie;
        // The collection of all the movies, the list that is displayed in the view.
        public ObservableCollection<Movie> Movies { get; set; }

        // Only accessible for the admin
        public RelayCommand AddMovie { get; set; }

        // Only accessible for the admin
        public RelayCommand DeleteMovie { get; set; }

        // Only accessible for the admin
        public Movie AddNewMovie { get; set; }

        public Movie SelectedMovie
        {
            get => _selectedMovie;
            set
            {
                _selectedMovie = value;
               OnPropertyChanged(nameof(SelectedMovie));
            }
        }


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

            AddMovie = new RelayCommand(DoAddMovie);
            DeleteMovie = new RelayCommand(DoDeleteMovie);

            AddNewMovie = new Movie();

            SelectedMovie = new Movie();

        }

        public void DoAddMovie()
        {
            Movies.Add(AddNewMovie);
        }

        public void DoDeleteMovie()
        {
            Movies.Remove(SelectedMovie);
        }

       


    }
}
