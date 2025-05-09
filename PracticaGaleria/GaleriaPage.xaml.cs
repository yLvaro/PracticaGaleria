using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PracticaGaleria
{
    public partial class GaleriaPage : ContentPage
    {
        public ObservableCollection<Animales> Animales { get; set; }
        public ICommand MostrarDetalleCommand { get; private set; }
        public ICommand AgregarAMiGaleriaCommand { get; private set; }

        public GaleriaPage()
        {
            InitializeComponent();

            // Inicializa la lista de animales
            Animales = new ObservableCollection<Animales>()
            {
                new Animales { Nombre = "Perro", ImagenRuta = "perro.jpg", Descripcion = "El mejor amigo del hombre." },
                new Animales { Nombre = "Gato", ImagenRuta = "gato.jpg", Descripcion = "El felino m�s com�n en las ciudades" },
                new Animales { Nombre = "Delf�n", ImagenRuta = "delfin.jpg", Descripcion = "Mam�fero acu�tico" },
                new Animales { Nombre = "Halc�n", ImagenRuta = "halcon.jpg", Descripcion = "Una de las aves m�s r�pidas del mundo" },
                // Agrega m�s animales aqu�
            };

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

            AgregarAMiGaleriaCommand = new Command<Animales>((animal) =>
            {
                if (animal != null)
                {
                    // Necesitamos una forma de comunicar esto a la GaleriaPersonalizadaPage
                    MessagingCenter.Send<GaleriaPage, Animales>(this, "AgregarAnimalPersonalizado", animal);
                }
            });


            BindingContext = this; // Establece el contexto de enlace
        }
    }
}