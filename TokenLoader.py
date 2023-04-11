import spotipy
from spotipy.oauth2 import SpotifyOAuth

if __name__ == "__main__":
    clientId = 'LE_CLIENT'
    clientSecret = 'LE_CLIENT_SECRET'
    scope = 'user-read-private user-read-email playlist-read-private'
    redirectURI = 'http://localhost'    # Attention à ce que la redirection soit whitelist !
    authManager = SpotifyOAuth(
        client_id=clientId,
        client_secret=clientSecret,
        scope=scope,
        redirect_uri=redirectURI
    )

    sp = spotipy.Spotify(auth_manager=authManager)

    dummyResultsToInvokePromptInWebBrowser = sp.current_user()      # Nécessaire pour faire apparaitre le prompt pour accepter l'authentification

    token = sp.auth_manager.get_cached_token()

    if sp.auth_manager.is_token_expired(token):
        sp.auth_manager.refresh_access_token(token['refresh_token'])
        token = sp.auth_manager.get_cached_token()

    print(token['access_token'])
