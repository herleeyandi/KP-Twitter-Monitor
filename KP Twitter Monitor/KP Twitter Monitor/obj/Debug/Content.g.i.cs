﻿#pragma checksum "c:\users\herleeyandi\documents\visual studio 2013\Projects\KP Twitter Monitor\KP Twitter Monitor\Content.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C56B5376BF9543DF93D6CB4F62FE1E0A"
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


namespace KP_Twitter_Monitor {
    
    
    public partial class Content : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama konten;
        
        internal Microsoft.Phone.Controls.PanoramaItem home;
        
        internal Microsoft.Phone.Controls.PanoramaItem favoritedata;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/KP%20Twitter%20Monitor;component/Content.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.konten = ((Microsoft.Phone.Controls.Panorama)(this.FindName("konten")));
            this.home = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("home")));
            this.favoritedata = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("favoritedata")));
        }
    }
}
