﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HafezMatteoSpotifyApp.Service;
using SpotifyAPI.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HafezMatteoSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPage : ContentPage
    {
        public CustomPage()
        {
            InitializeComponent();
            PrivateUser userClient = SpotifyService.Instance.GetSpotifyClient().UserProfile.Current().Result;
            this.AlbumPicture.Source = userClient.Images[0].Url;    // Ne charge pas à cause du certificat
            this.AlbumName.Text = userClient.DisplayName;
        }
    }
}