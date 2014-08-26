using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Net.NetworkInformation;

namespace QuoraApp
{
    /*
    public class UriFormatException : FormatException
    {
        public UriFormatException()
        {
            
        }
    }
     */
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            Application.Current.Host.Settings.EnableFrameRateCounter = false;

           
            MiniBrowser.Navigate(new Uri("http://www.quora.com/"));
            MiniBrowser.IsScriptEnabled=true;
            MiniBrowser.IsGeolocationEnabled = true;

            MiniBrowser.Navigated += new EventHandler<System.Windows.Navigation.NavigationEventArgs>(MiniBrowser_Navigated);
            MiniBrowser.Navigating += new EventHandler<NavigatingEventArgs>(MiniBrowser_Navigating);
            MiniBrowser.ScriptNotify += new EventHandler<NotifyEventArgs>(MiniBrowser_ScriptNotify);

            

            
        }


        

        void MiniBrowser_ScriptNotify(object sender, NotifyEventArgs e)
        {
            MiniBrowser.Navigate(new Uri(e.Value, UriKind.Absolute));
        }

        void MiniBrowser_Navigating(object sender, NavigatingEventArgs e)
        {
            ProgBar.Visibility = Visibility.Visible;
        }

        void MiniBrowser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            ProgBar.Visibility = Visibility.Collapsed;
        }

        private void Home_Click(object sender, EventArgs e)
        {
           
           
            MiniBrowser.Navigate(new Uri("http://www.quora.com/"));
            //Do work for your application here.
        }

        private void Follow_Click(object sender, EventArgs e)
        {
            MiniBrowser.Navigate(new Uri("http://www.quora.com/Kashyap-Bhansali"));
            //Do work for your application here.
        }
        private void Blog_Click(object sender, EventArgs e)
        {
            MiniBrowser.Navigate(new Uri("http://techbum.blogspot.com/"));
            //Do work for your application here.
        }

        private void OpenQuestions_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Button: Back works!");
            MiniBrowser.Navigate(new Uri("http://www.quora.com/open_questions"));
            //Do work for your application here.
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            MiniBrowser.Navigate(new Uri("http://www.quora.com/credits"));
            //Do work for your application here.
        }

        private void Content_Click(object sender, EventArgs e)
        {
            MiniBrowser.Navigate(new Uri("http://www.quora.com/content"));
            //Do work for your application here.
        }

        private void Forward_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Button: forward works!");
            MiniBrowser.GoForward();
            //Do work for your application here.
        }

        private void Back_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Button: Back works!");
            MiniBrowser.GoBack();
            //Do work for your application here.
        }

        private void Notifications_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Button: Back works!");
            MiniBrowser.Navigate(new Uri("http://www.quora.com/notifications"));
            //Do work for your application here.
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Button: Back works!");
            MiniBrowser.Navigate(new Uri("http://www.quora.com/stats"));
            //Do work for your application here.
        }
        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);


        }


        
    }

    
}

