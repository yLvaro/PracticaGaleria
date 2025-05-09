namespace PracticaGaleria
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Rutas de navegación
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));            
            Routing.RegisterRoute(nameof(GaleriaPage), typeof(GaleriaPage));
            Routing.RegisterRoute(nameof(Configuracion), typeof(Configuracion));
            Routing.RegisterRoute(nameof(DetallesAnimalesPage), typeof(DetallesAnimalesPage));
            Routing.RegisterRoute(nameof(GalPersonalizadaPage), typeof(GalPersonalizadaPage));
        }
    }
}
