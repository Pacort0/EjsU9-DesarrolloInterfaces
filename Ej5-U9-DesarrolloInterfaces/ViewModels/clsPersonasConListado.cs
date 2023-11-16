using bibliotecaEj3;
using Ej5_U9_DesarrolloInterfaces.Models.DAL;
using System.Collections.ObjectModel;

namespace Ej5_U9_DesarrolloInterfaces.ViewModels
{
    internal class clsPersonasConListado:clsPersona
    {
        private ObservableCollection<clsPersona> listaPersonas;

        public clsPersonasConListado()
        {
            listaPersonas = clsListados.listadoPersonas();
        }
        public ObservableCollection<clsPersona> ListaPersonas
        {
            get { return listaPersonas; }
        }   
    }
}
