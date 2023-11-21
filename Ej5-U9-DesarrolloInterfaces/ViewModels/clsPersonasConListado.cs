using bibliotecaEj3;
using Ej5_U9_DesarrolloInterfaces.Models.DAL;
using Ej5_U9_DesarrolloInterfaces.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ej5_U9_DesarrolloInterfaces.ViewModels
{
    internal class clsPersonasConListado:clsPersona, INotifyPropertyChanged
    {
        private ObservableCollection<clsPersona> listaPersonas;
        private clsPersona persona;
        private INavigation navigation;

        public clsPersonasConListado()
        {
            listaPersonas = clsListados.listadoPersonas();
        }
        public clsPersonasConListado(INavigation _navigation)
        {
            navigation = _navigation;
        }

        public ObservableCollection<clsPersona> ListaPersonas
        {
            get { return listaPersonas; }
        }

        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        public clsPersona Persona
        { 
            get { return persona; } 
            set { persona = value;

                OnPropertyChanged();

                OnTapped(persona);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string atributo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }
        private void OnTapped(clsPersona persona)
        {  
            Navigation.PushAsync(new Detalles { BindingContext = persona});
        }
    }
}
