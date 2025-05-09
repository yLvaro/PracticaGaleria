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

            // Aqu� deber�as implementar la l�gica de autenticaci�n real
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
                            Title = "Galer�a",
                            Icon = "galleryicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Galer�a",
                                    ContentTemplate = new DataTemplate(typeof(GaleriaPage)),
                                    Route = "GaleriaPage"
                                }
                            }
                        },
                        new FlyoutItem
                        {
                            Title = "Configuraci�n",
                            Icon = "settingsicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Configuraci�n",
                                    ContentTemplate = new DataTemplate(typeof(Configuracion)),
                                    Route = "Configuracion"
                                }
                            }
                        },

                        new FlyoutItem
                        {
                            Title = "Galer�a personalizada",
                            Icon = "settingsicon.png",
                            Items =
                            {
                                new ShellContent
                                {
                                    Title = "Galer�a personalizada",
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