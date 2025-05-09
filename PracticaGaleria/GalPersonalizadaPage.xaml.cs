using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PracticaGaleria
{
    public partial class GalPersonalizadaPage : ContentPage
    {
        public ObservableCollection<Animales> AnimalesPersonalizados { get; set; }
        public ICommand MostrarDetalleCommand { get; private set; }

        public GalPersonalizadaPage()
        {
            InitializeComponent();
            AnimalesPersonalizados = new ObservableCollection<Animales>();
            MostrarDetalleCommand = new Command<Animales>(async (animal) =>
            {
                if (animal != null)
                {
                    await Shell.Current.GoToAsync(nameof(DetallesAnimalesPage),
                        new Dictionary<string, object>
                        {
                            { "Animal", animal }
                        });
                }
            });
            BindingContext = this;

            // Suscribirse al mensaje de agregar animal a la galería personalizada
            MessagingCenter.Subscribe<GaleriaPage, Animales>(this, "AgregarAnimalPersonalizado", (sender, animalSeleccionado) =>
            {
                if (!AnimalesPersonalizados.Any(a => a.Nombre == animalSeleccionado.Nombre)) // Evitar duplicados
                {
                    AnimalesPersonalizados.Add(animalSeleccionado);
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // Importante: Desuscribirse del mensaje
            MessagingCenter.Unsubscribe<GaleriaPage, Animales>(this, "AgregarAnimalPersonalizado");
        }
    }
}

