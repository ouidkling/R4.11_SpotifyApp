using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HafezMatteoSpotifyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckerboardView : ContentView
    {
        public static readonly BindableProperty CustomViewProperty = BindableProperty.Create(nameof(CustomView), typeof(View), typeof(CheckerboardView), null, propertyChanged: OnCustomViewChanged);

        public CheckerboardView()
        {
            InitializeComponent();
        }
        public View CustomView
        {
            get => (View)GetValue(CustomViewProperty);
            set => SetValue(CustomViewProperty, value);
        }
        
        private static void OnCustomViewChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // (CheckerboardView)bindable).CheckerboardGrid.Children.Add((View)newValue);
        }
    }
}