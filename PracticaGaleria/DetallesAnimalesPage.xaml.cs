namespace PracticaGaleria
{
    [QueryProperty(nameof(Animales), "Animal")]
    public partial class DetallesAnimalesPage : ContentPage
    {
        public Animales Animales
        {
            get => BindingContext as Animales;
            set => BindingContext = value;
        }

        public DetallesAnimalesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Animales != null)
            {
                AnimalImagen.Source = Animales.ImagenRuta;
                NombreAnimalLabel.Text = Animales.Nombre;
                DescripcionAnimalLabel.Text = Animales.Descripcion;
                Width.CompareTo(Animales.TamañoImagenAncho);
                Height.CompareTo(Animales.TamañoImagenAlto);
            }
        }
    }
}