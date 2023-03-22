using Xamarin.Forms;

namespace HafezMatteoSpotifyApp.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        #region Instance

        public static StartPageViewModel Instance { get; } = new StartPageViewModel();

        #endregion

        public StartPageViewModel()
        {
            FirstColor = Color.FromHex("#1DB954");
            SecondColor = Color.FromHex("#191414");
            ThirdColor = Color.FromHex("#FFFFFF");
        }

        public Color FirstColor
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }

        public Color SecondColor
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }
        
        public Color ThirdColor
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }

        public void UpdateColors()
        {
            var temp = ThirdColor;
            ThirdColor = SecondColor;
            SecondColor = FirstColor;
            FirstColor = temp;
        }

    }
}
