using HafezMatteoSpotifyApp.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HafezMatteoSpotifyApp.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        #region Instance

        public static StartPageViewModel Instance { get; } = new StartPageViewModel();

        #endregion

        public StartPageViewModel()
        {
            FirstColor = Color.Blue;
            SecondColor = Color.Pink;
            ThirdColor = Color.Aqua;
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
            if (FirstColor == Color.Red)
            {
                FirstColor = Color.Blue;
                SecondColor = Color.Pink;
                ThirdColor = Color.Aqua;
            }
            else
            {
                FirstColor = Color.Red;
                SecondColor = Color.Green;
                ThirdColor = Color.Yellow;
            }
        }

    }
}
