using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WPIsoStorage.Resources;

namespace WPIsoStorage
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private void RemoveUser(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.CommandParameter != null)
            {
                var id = (Guid)button.CommandParameter;
                var users = App.ViewModel.Users;
                var tempUser = users.SingleOrDefault(u => u.Id == id);
                if (tempUser != null)
                {
                    users.Remove(tempUser);    
                }
                
            }
        }


        private void AddUser(object sender, RoutedEventArgs e)
        {
            var user = new User();
            user.Id = Guid.NewGuid();
            user.Name = "User - " + (App.ViewModel.Users.Count + 1);
            user.AddedOn = DateTime.Now;
            App.ViewModel.Users.Add(user);
        }

        private void RemoveAll(object sender, RoutedEventArgs e)
        {
            App.ViewModel.Users.Clear();
        }
    }
}