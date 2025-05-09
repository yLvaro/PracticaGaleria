namespace PracticaGaleria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnIrAGaleriaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GaleriaPage));
        }
    }

}
