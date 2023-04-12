using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HafezMatteoSpotifyApp.Service
{
    public class SpotifyService
    {
        private const string TokenSpotify = "BQBC-39MPBJPPpSxZplgFO7OHZHmJ2bGYQjst2T8MjRWXX4GwmR0Ruwozl7T_kFA6b3UuPxG9MFVyrI3xMmDOkmav3b3XWB4DNubXIK3ZoXPwahH4DUkYI9l-OWFII1XdYe-ASVjcbtrnSOBD_JVL4qoxmJw9CohZ_FeVesTd9QaiShKAAO_UmziJNLwmXQ0hIV6nG4saHLC4qqvwshlgw";
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