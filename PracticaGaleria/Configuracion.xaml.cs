namespace PracticaGaleria;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private async void TamañoImagenPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (TamañoImagenPicker.SelectedIndex != -1)
        {
            string tamañoSeleccionado = TamañoImagenPicker.SelectedItem.ToString();
            // Guardar el tamaño en las preferencias de la aplicación
            Preferences.Set("TamañoImagenGaleria", tamañoSeleccionado);
            // Opcional: Mostrar un mensaje al usuario
            await DisplayAlert("Tamaño Guardado", $"El tamaño de la imagen se ha establecido a {tamañoSeleccionado}.", "OK");
        }
    }
}