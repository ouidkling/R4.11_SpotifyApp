using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HafezMatteoSpotifyApp.Service
{
    public class SpotifyService
    {
        private const string TokenSpotify = "BQArodv9uJdE8uKbFm9-USV7DkMtQE4j_XxZc7zWq6gM6TwTYebxNtJ8b3PZyxG-WbTrdeSi6DSF1wiOn9sKIAkYO9wQlXqxu4cJfqH91rLcCxNWTBDziLsPaoAuyelDgAL4svEN2dBG_eCqRzbeTF1Pd5fWFoV1NUB7poWCUTiE0Q33PDBqWKNFjHq4zvUwBuIfmSTB4NQJu1bTyrdeJVQ7xG_l2e0sZ6Gh6fe1CJlD65hoJBE9f3DeBPBWOL3BmNgqiBSWaqSSGV6KmUMs2OHXVwXMAOkJ9aFr5qZqWUHaUPkDxsy5";
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