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
    public partial class ArtistPage : ContentPage
    {
        public ArtistPage()
        {
            InitializeComponent();
            FullArtist _ArtisteClient = SpotifyService.Instance.GetSpotifyClient().Artists.Get("4IF11U0nzFhAaLDGZH3vSx").Result;
            this.PhotoArtiste.Source = _ArtisteClient.Images[0].Url;
            this.NomArtiste.Text = _ArtisteClient.Name;
        }
    }
}