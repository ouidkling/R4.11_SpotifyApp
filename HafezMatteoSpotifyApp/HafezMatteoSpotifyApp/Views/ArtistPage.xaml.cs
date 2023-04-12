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
            FullArtist artistClient = SpotifyService.Instance.GetSpotifyClient().Artists.Get("65C6Unk7nhg2aCnVuAPMo8").Result;
            this.ArtistPicture.Source = artistClient.Images[0].Url;
            this.ArtistName.Text = artistClient.Name;
            this.ArtistGenre.ItemsSource = artistClient.Genres;
            this.ArtistFollowers.Text = artistClient.Followers.Total.ToString();
            this.ArtistPopularity.Text = $"{artistClient.Popularity.ToString()}%";
        }
    }
}