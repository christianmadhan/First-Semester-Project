using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using MovieApp.Model;
using MovieApp.View;
namespace MovieApp.View_Model
{
  public  class MovieList : NotifyChanged
    {
        private Movie _selectedMovie;

        private readonly FrameNavigate _frameNavigate;

        private readonly Singleton _userSingleton;

        private SingletonMovieList _singleton = SingletonMovieList.GetInstance();
        
        // The collection of all the movies, the list that is displayed in the view.
        public ObservableCollection<Movie> Movies { get; set; }

        // Only accessible for the admin
        public RelayCommand AddMovie { get; set; }

        // Only accessible for the admin
        public RelayCommand DeleteMovie { get; set; }

        public RelayCommand GoToBuyFoodPageCommand { get; set; }

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


        // Returns the global list to the view.
        public MovieList()
        {
            try
            {

                Movies = new ObservableCollection<Movie>();

                var movieList = _singleton.GetMovieList();

                Movies = movieList;

            }
            catch (Exception e)
            {
                var dialog = new MessageDialog(e.Message);
            }


            AddMovie = new RelayCommand(DoAddMovie);
            DeleteMovie = new RelayCommand(DoDeleteMovie);
            GoToBuyFoodPageCommand = new RelayCommand(DoPageBuyFood);

            AddNewMovie = new Movie();

            SelectedMovie = new Movie();

            _frameNavigate = new FrameNavigate();

            _userSingleton = Singleton.GetInstance();

        }

        public void DoAddMovie()
        {
           _singleton.GetMovieList().Add(AddNewMovie);
        }

        public void DoDeleteMovie()
        {
            _singleton.GetMovieList().Remove(SelectedMovie);
        }

        public async void DoPageBuyFood()
        {
            // You cannot continue if you havent picked a movie
            if (_selectedMovie.Price == 0)
            {
                var dialog = new MessageDialog("You have to pick a movie");
                await dialog.ShowAsync();
            }
            else
            {
                _userSingleton.SetMovie(_selectedMovie);
                Type type = typeof(FoodPage);
                _frameNavigate.ActivateFrameNavigation(type);
            }
        }


    }
}
