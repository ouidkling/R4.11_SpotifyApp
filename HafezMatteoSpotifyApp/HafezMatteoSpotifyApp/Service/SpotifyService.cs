using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HafezMatteoSpotifyApp.Service
{
    public class SpotifyService
    {
        private const string TokenSpotify = "LE_TOKEN";
        // private const string ClientId = "LE_CLIENT";
        // private const string ClientSecret = "LE_CLIENT_SECRET";
        
        private SpotifyClient _spotifyClient;
        #region Instance

        public static SpotifyService Instance { get; } = new SpotifyService();

        #endregion

        public async Task<bool> ConnectSpotify()
        {
            try
            {
                _spotifyClient = new SpotifyClient(TokenSpotify);
                
                /*
                var config = SpotifyClientConfig
                    .CreateDefault()
                    .WithAuthenticator(new ClientCredentialsAuthenticator(ClientId, ClientSecret));
                
                _spotifyClient = new SpotifyClient(config);
                */
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