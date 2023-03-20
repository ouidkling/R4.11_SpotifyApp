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
                // Première ligne
                new CheckerboardBox()
                {
                    BoxRow = "0",
                    BoxColumn = "0",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "0",
                    BoxColumn = "1",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "0",
                    BoxColumn = "2",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "0",
                    BoxColumn = "3",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "0",
                    BoxColumn = "4",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                // Deuxième ligne
                new CheckerboardBox()
                {
                    BoxRow = "1",
                    BoxColumn = "0",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "1",
                    BoxColumn = "1",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "1",
                    BoxColumn = "2",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "1",
                    BoxColumn = "3",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "1",
                    BoxColumn = "4",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                // Troisième ligne
                new CheckerboardBox()
                {
                    BoxRow = "2",
                    BoxColumn = "0",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "2",
                    BoxColumn = "1",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },new CheckerboardBox()
                {
                    BoxRow = "2",
                    BoxColumn = "2",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "2",
                    BoxColumn = "3",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "2",
                    BoxColumn = "4",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },
                // Quatrième ligne
                new CheckerboardBox()
                {
                    BoxRow = "3",
                    BoxColumn = "0",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "3",
                    BoxColumn = "1",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "3",
                    BoxColumn = "2",
                    BoxColor = Application.Current.Resources["AccentColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "3",
                    BoxColumn = "3",
                    BoxColor = Application.Current.Resources["PrimaryColor"].ToString(),
                },
                new CheckerboardBox()
                {
                    BoxRow = "3",
                    BoxColumn = "4",
                    BoxColor = Application.Current.Resources["SecondaryColor"].ToString(),
                },
            };
        }
        
        public void ChangeColor()
        {
            foreach (var item in Items)
            {
                if (item.BoxColor == Application.Current.Resources["PrimaryColor"].ToString())
                    item.BoxColor = Application.Current.Resources["SecondaryColor"].ToString();
                else if (item.BoxColor == Application.Current.Resources["SecondaryColor"].ToString())
                    item.BoxColor = Application.Current.Resources["AccentColor"].ToString();
                else if (item.BoxColor == Application.Current.Resources["AccentColor"].ToString())
                    item.BoxColor = Application.Current.Resources["PrimaryColor"].ToString();
            }
        }
    }
}