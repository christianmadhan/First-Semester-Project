using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MovieApp.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int change = 1;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(4);
            timer.Tick += (o, a) =>
            {
                // If we'd go out of bounds then reverse
                int newIndex = MovieFlip.SelectedIndex + change;
                if (newIndex >= MovieFlip.Items.Count || newIndex < 0)
                {
                    change *= -1;
                }

                MovieFlip.SelectedIndex += change;
            };
            timer.Start();
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
    }
}
