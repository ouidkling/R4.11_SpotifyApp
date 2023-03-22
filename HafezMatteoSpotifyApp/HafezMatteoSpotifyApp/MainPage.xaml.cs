using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HafezMatteoSpotifyApp.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HafezMatteoSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : Shell
    {
        public BasePage()
        {
            InitializeComponent();
        }
    }
}