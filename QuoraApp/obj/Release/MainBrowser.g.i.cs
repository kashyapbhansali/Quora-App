﻿#pragma checksum "C:\Users\Kbhansali\documents\visual studio 2012\Projects\QuoraApp\QuoraApp\MainBrowser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "838D019D3F01C9422A268E7F0AB3E3EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace QuoraApp {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.WebBrowser MiniBrowser;
        
        internal System.Windows.Controls.ProgressBar ProgBar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/QuoraApp;component/MainBrowser.xaml", System.UriKind.Relative));
            this.MiniBrowser = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("MiniBrowser")));
            this.ProgBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgBar")));
        }
    }
}

