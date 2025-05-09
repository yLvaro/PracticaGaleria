namespace PracticaGaleria;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private async void Tama�oImagenPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Tama�oImagenPicker.SelectedIndex != -1)
        {
            string tama�oSeleccionado = Tama�oImagenPicker.SelectedItem.ToString();
            // Guardar el tama�o en las preferencias de la aplicaci�n
            Preferences.Set("Tama�oImagenGaleria", tama�oSeleccionado);
            // Opcional: Mostrar un mensaje al usuario
            await DisplayAlert("Tama�o Guardado", $"El tama�o de la imagen se ha establecido a {tama�oSeleccionado}.", "OK");
        }
    }
}