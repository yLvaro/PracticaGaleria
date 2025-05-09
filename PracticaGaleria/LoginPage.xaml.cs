namespace PracticaGaleria
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Aquí deberías implementar la lógica de autenticación real
            if (username == "1" && password == "1")
            {
                // Reemplazar el contenido del Shell con la estructura del Flyout
                Application.Current.MainPage = new Shell
                {
                    FlyoutBehavior = FlyoutBehavior.Flyout,
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Home",
                            ContentTemplate = new DataTemplate(typeof(MainPage)),
                            Route = "MainPage"
                        },
                        new FlyoutItem
                        {
                            Title = "Galería",
                            Icon = "galleryicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Galería",
                                    ContentTemplate = new DataTemplate(typeof(GaleriaPage)),
                                    Route = "GaleriaPage"
                                }
                            }
                        },
                        new FlyoutItem
                        {
                            Title = "Configuración",
                            Icon = "settingsicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Configuración",
                                    ContentTemplate = new DataTemplate(typeof(Configuracion)),
                                    Route = "Configuracion"
                                }
                            }
                        },

                        new FlyoutItem
                        {
                            Title = "Galería personalizada",
                            Icon = "settingsicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Galería personalizada",
                                    ContentTemplate = new DataTemplate(typeof(GalPersonalizadaPage)),
                                    Route = "GalPersonalizadaPage"
                                }
                            }
                        }

                    }
                };
            }
            else
            {
                MessageLabel.Text = "Credenciales incorrectas.";
            }
        }
    }
}