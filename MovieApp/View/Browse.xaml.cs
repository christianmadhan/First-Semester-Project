using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MovieApp.Model;
using MovieApp.View_Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MovieApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Browse : Page
    {
        public RelayCommand FindMovies { get; set; }

        private SingletonMovieList _singleton = SingletonMovieList.GetInstance();

        private ObservableCollection<Movie> ResetList= new ObservableCollection<Movie>();
        public Browse()
        {
            this.InitializeComponent();

            foreach (var movie in _singleton.GetMovieList())
            {
                ResetList.Add(movie);
            }

        }

        private void ContinueButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void SearchGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog
            ("You have successfully booked the property"
            );
        }


        // It works, but will wait to see if marek have coded something better
        private async void FilterMovies(object sender, RoutedEventArgs e)
        {

            try
            {
                var myCollection = _singleton.GetMovieList();
                var selectedGenre = FilterGenres.SelectionBoxItem.ToString();
                foreach (var movie in myCollection.ToList())
                {
                    if (movie.Genre != selectedGenre)
                    {
                        myCollection.Remove(movie);
                    }
                }
            }
            catch (Exception exception)
            {
                var dialig = new MessageDialog(exception.Message);
                await dialig.ShowAsync();
            }
        }

        


   
        private void ResetBtn(object sender, RoutedEventArgs e)
        {
            foreach (var movie in ResetList)
            {
                _singleton.GetMovieList().Add(movie);
            }
        }
    }
    }

