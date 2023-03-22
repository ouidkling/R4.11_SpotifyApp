using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HafezMatteoSpotifyApp.Service
{
    public class SpotifyService
    {
        private const string TokenSpotify = "BQDA0HBAFIjQSiK1mecqVL2WpjAOQVFPx5v4plwUbkhxFVhYZ98M8WskD5UoGlwPQcPyVgm-jFeDA-WkoA05yXjDB-1qtrDWHANBGPkee79MBsnGYnaFIC3iDPdIPcVSHrexrCC5o9L1K9YUoagb7Cwp_1Fy0l3pakulv6IYTmVWw6jUY5U1EEtV0Ahc3eGUpc8kvwSUod0IaujbZUc6tL2HKpUe_E2oAjV_rib7c7FPOMnQpF1xIZn7Mu8kYH9n_OHXBfo0Z1Z-3XITm-XV4qRUbWBc4dmGfMQaO8N6_QygxHB4hMaw";
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