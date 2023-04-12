using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HafezMatteoSpotifyApp.Service;
using Plugin.AudioRecorder;
using SpotifyAPI.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HafezMatteoSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPage : ContentPage
    {
        private readonly AudioPlayer _audioPlayer = new AudioPlayer();
        
        public CustomPage()
        {
            InitializeComponent();
            PrivateUser userClient = SpotifyService.Instance.GetSpotifyClient().UserProfile.Current().Result;
            this.ProfilePicture.Source = userClient.Images[0].Url;
            this.Username.Text = userClient.DisplayName;
            Paging<SimplePlaylist> userPlaylistsClient = SpotifyService.Instance.GetSpotifyClient().Playlists.CurrentUsers().Result;
            this.UserPlaylists.BindingContext = userPlaylistsClient.Items;
        }


        private void PlayRandomMusic(object sender, EventArgs e)
        {
            var playlistId = ((SimplePlaylist)((ImageButton)sender).BindingContext).Id;
            var playlistClient = SpotifyService.Instance.GetSpotifyClient().Playlists.Get(playlistId).Result;
            var random = new Random();
            var randomTrack = random.Next(playlistClient.Tracks.Items.Count);
            foreach (PlaylistTrack<IPlayableItem> item in playlistClient.Tracks.Items)
            {
                if (item.Track is FullTrack track && randomTrack == playlistClient.Tracks.Items.IndexOf(item))
                {
                    _audioPlayer.Play(track.PreviewUrl);
                }
                if (item.Track is FullEpisode episode && randomTrack == playlistClient.Tracks.Items.IndexOf(item))
                {
                    // All FullTrack properties are available
                    Console.WriteLine(episode.AudioPreviewUrl);
                }
            }
        }
    }
}