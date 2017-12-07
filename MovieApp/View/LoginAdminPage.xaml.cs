﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Audio;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace MovieApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginAdminPage : Page
    {
        public LoginAdminPage()
        {
            this.InitializeComponent();
        }

        private async void LoginToAdminPage(object sender, RoutedEventArgs e)
        {
            if (userNameBox.Text == "root" && PasswordBox.Password == "123")
            {
                Frame.Navigate(typeof(AdminPage));
            }
            else
            {
                var dialog = new MessageDialog("Wrong Username or Password");
                await dialog.ShowAsync();
            }
        }
        

        private void BackToMainPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Browse));
        }
    }
}
