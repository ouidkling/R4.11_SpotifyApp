using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HafezMatteoSpotifyApp.Service
{
    public class SpotifyService
    {
        private const string TokenSpotify = "BQBZrjTxIOOIP6S03i4czkqlodBDQ2QRrVHBj3FXoB_5rSU1skGFBI3xfs_e-P0l3RaP3t_8YyigoyqlKUI0U3HTN0h35wHr28L7ArdadhBjP8G0KkXh";
        private SpotifyClient _spotifyClient;
        #region Instance

        public static SpotifyService Instance { get; } = new SpotifyService();

        #endregion

        public async Task<bool> ConnectSpotify()
        {
            try
            {
                _spotifyClient = new SpotifyClient(TokenSpotify);
                return await Task.FromResult(true);
            }
            catch (Exception exception)
            {
                return await Task.FromResult(false);
            }
        }

        public SpotifyClient GetSpotifyClient()
        {
            return _spotifyClient;
        }
    }
}