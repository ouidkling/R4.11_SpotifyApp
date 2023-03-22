using HafezMatteoSpotifyApp.ViewModels;
using System;
using HafezMatteoSpotifyApp.Service;
using Xamarin.Forms;

namespace HafezMatteoSpotifyApp
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = StartPageViewModel.Instance;
            SpotifyService.Instance.ConnectSpotify();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            StartPageViewModel.Instance.UpdateColors();
        }
    }
}
