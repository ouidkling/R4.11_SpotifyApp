using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HafezMatteoSpotifyApp.Service;
using SpotifyAPI.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HafezMatteoSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumPage : ContentPage
    {
        public AlbumPage()
        {
            InitializeComponent();
            FullAlbum albumClient = SpotifyService.Instance.GetSpotifyClient().Albums.Get("7K8URwf6BeFpzg7dE2TU1W").Result;
            this.AlbumPicture.Source = albumClient.Images[0].Url;
            this.AlbumName.Text = albumClient.Name;
            // Associé à la première façon de faire (voir fichier .xaml)
            // String albumArtistName = albumClient.Artists[0].Name;
            // String albumReleaseDate = albumClient.ReleaseDate;
            // this.AlbumArtistRelease.Text = albumArtistName + " - " + albumReleaseDate;
            this.AlbumArtistName.Text = albumClient.Artists[0].Name;
            this.AlbumReleaseDate.Text = albumClient.ReleaseDate;
            this.AlbumTracks.ItemsSource = albumClient.Tracks.Items;
        }
    }
}