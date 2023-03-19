using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace HafezMatteoSpotifyApp
{
    public class Checkerboard : INotifyPropertyChanged
    {
        private ObservableCollection<CheckerboardBox> items;
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public ObservableCollection<CheckerboardBox> Items
        {
            get => items;
            set
            {
                items = value;
            }
        }
        
        public Checkerboard()
        {
            Items = new ObservableCollection<CheckerboardBox>()
            {
                new CheckerboardBox()
                {
                    boxType = 1,
                    boxColor = (Color) Application.Current.Resources["PrimaryColor"],
                },
                new CheckerboardBox()
                {
                    boxType = 2,
                    boxColor =  (Color) Application.Current.Resources["SecondaryColor"],
                },
                new CheckerboardBox()
                {
                    boxType = 3,
                    boxColor =  (Color) Application.Current.Resources["AccentColor"],
                },
            };
        }
        
        public void ChangeColor()
        {
            var temp = Items[0];
            Items[0] = Items[1];
            Items[1] = Items[2];
            Items[2] = temp;
        }
    }
}