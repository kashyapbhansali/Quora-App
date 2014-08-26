using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using QuoraApp.Resources;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Net.NetworkInformation;
using System.Threading;

namespace QuoraApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            var ni = NetworkInterface.NetworkInterfaceType;

            //Checking for internet connection...
            if ((ni == NetworkInterfaceType.Wireless80211) || (ni == NetworkInterfaceType.MobileBroadbandCdma) || (ni == NetworkInterfaceType.MobileBroadbandGsm))
            { }

            else if (ni == NetworkInterfaceType.None)
            {
                MessageBox.Show("Not connected to Internet. Please check your connection!");
            }

            InitializeComponent();
            
            Application.Current.Host.Settings.EnableFrameRateCounter = false;
            
            /*
            if (!checkNetworkConnection())
            {
                MessageBox.Show("Not connected to Internet. Please check your connection!");
            }
            */
            


        }
        /*
        public static bool checkNetworkConnection()
        {
            var ni = NetworkInterface.NetworkInterfaceType;

            bool IsConnected = false;
            if ((ni == NetworkInterfaceType.Wireless80211) || (ni == NetworkInterfaceType.MobileBroadbandCdma) || (ni == NetworkInterfaceType.MobileBroadbandGsm))
                IsConnected = true;
            else if (ni == NetworkInterfaceType.None)
                IsConnected = false;
            return IsConnected;
        }*/

       


        private void passParam_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainBrowser.xaml"));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rate_Click(object sender, RoutedEventArgs e)
        {
            var a = new MarketplaceReviewTask();
            a.Show();
           
            //MessageBox.Show("Thanks for rating this app. We are working to make it better!");
        }

        private void Share_Click(object sender, RoutedEventArgs e)
        {
            ShareLinkTask shareLinkTask = new ShareLinkTask();

            shareLinkTask.Title = "Quora Client for Windows Phone";
            shareLinkTask.LinkUri = new Uri("http://bit.ly/kkbwpapp", UriKind.Absolute);
            shareLinkTask.Message = "New Quora Client for Windows Phone! Well designed UI";

            shareLinkTask.Show();
        }

        private void Mail_Click(object sender, RoutedEventArgs e)
        {
           // EmailComposeTask emailComposeTask = new EmailComposeTask();

            //emailComposeTask.Subject = "Check out the new Quora Client for WP!";
            //emailComposeTask.Body = "Quora Client is a new app for windows phone 7.x/8.x. I feel should try it out too! :)";
            //emailComposeTask.Show();

            //MessageBox.Show("Thanks for rating this app. We are working to make it better!");
            ShareLinkTask shareLinkTask = new ShareLinkTask();

            shareLinkTask.Title = "Quora Client";
            shareLinkTask.LinkUri = new Uri("http://bit.ly/kkbwpapp", UriKind.Absolute);
            shareLinkTask.Message = "Here great Quora Client for Windows Phone. Try it out!";

            shareLinkTask.Show();
        }

        private void Button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainBrowser.xaml", UriKind.Relative));
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
    }
}