using bibliotecaEj3;
using Ej5_U9_DesarrolloInterfaces.Models.DAL;
using Ej5_U9_DesarrolloInterfaces.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ej5_U9_DesarrolloInterfaces.ViewModels
{
    internal class clsPersonasConListado:clsPersona
    {
        private ObservableCollection<clsPersona> listaPersonas;
        private clsPersona persona;

        public clsPersonasConListado()
        {
            listaPersonas = clsListados.listadoPersonas();
        }
        public ObservableCollection<clsPersona> ListaPersonas
        {
            get { return listaPersonas; }
        }   
        public clsPersona Persona
        { 
            get { return persona; } 
            set { persona = value;
                new Detalles() { BindingContext = persona };
            }
        }
    }
}
