using bibliotecaEj3;

namespace Ej5_U9_DesarrolloInterfaces.Views;

public partial class listaPersonas : ContentPage
{
	public listaPersonas()
	{
		InitializeComponent();
	}
    private void listaDePersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Navigation.PushAsync(new Detalles() { BindingContext = e.SelectedItem as clsPersona });
    }
}