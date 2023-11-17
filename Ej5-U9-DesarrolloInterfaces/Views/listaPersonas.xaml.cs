using bibliotecaEj3;

namespace Ej5_U9_DesarrolloInterfaces.Views;

public partial class listaPersonas : ContentPage
{
	public listaPersonas()
	{
		InitializeComponent();
	}

    private async void listaDePersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		await Navigation.PushAsync(new Detalles { BindingContext = e.SelectedItem });
    }
}