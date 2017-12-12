using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        private  SingletonMovieList _singleton = SingletonMovieList.GetInstance();

        private  ObservableCollection<Movie> ResetList= new ObservableCollection<Movie>();
        public Browse()
        {
            this.InitializeComponent();

            foreach (var movie in _singleton.GetMovieList())
            {
                ResetList.Add(movie);
            }

        }


        private void SearchGenres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog
            ("You have successfully booked the property");
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
            var myCollection = _singleton.GetMovieList();
            foreach (var movie in ResetList)
            {
                if (movie.Genre != FilterGenres.SelectionBoxItem.ToString())
                {
                    _singleton.GetMovieList().Add(movie);
                }
            }
        }

        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void BrowseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Browse));
        }

        private void AboutButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void AdminButton_OnClick(object sender, RoutedEventArgs e)
        {
            if ((App.Current as App).adminSession)
            {
                Frame.Navigate(typeof(AdminPage));
            }
            else
            {
                Frame.Navigate(typeof(LoginAdminPage));
            }
        }


        //TODO
        private void SortTheList(object sender, RoutedEventArgs e)
        {
            if ((bool)PriceSortRB.IsChecked)
            {
                _singleton.SortListPrice();
            }

            if ((bool)AlphabetSortRB.IsChecked)
            {
                _singleton.SortListAlphabetically();
            }
        }

    }
    }

