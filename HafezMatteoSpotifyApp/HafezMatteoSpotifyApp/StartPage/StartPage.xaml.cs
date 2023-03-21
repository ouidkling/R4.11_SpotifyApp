using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HafezMatteoSpotifyApp
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = new Checkerboard();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            // Checkerboard.ChangeColor();
        }
    }
}
