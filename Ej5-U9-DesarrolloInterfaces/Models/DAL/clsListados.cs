using bibliotecaEj3;
using System.Collections.ObjectModel;

namespace Ej5_U9_DesarrolloInterfaces.Models.DAL
{
    internal static class clsListados
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<clsPersona> listadoPersonas()
        {
            ObservableCollection<clsPersona> listaPersonas = new ObservableCollection<clsPersona>()
            {
                new clsPersona() {Id=1, Nombre="David", Apellidos="Raya", Direccion="Calle del Terror", FechaNac="27/03/1990", ImageURL="https://thispersondoesnotexist.com/", Telefono=674532431},
                new clsPersona() {Id=2, Nombre="Lamine", Apellidos="Yamal", Direccion="Calle del Terror", FechaNac="27/03/2006", ImageURL="https://thispersondoesnotexist.com/", Telefono=685464332},
                new clsPersona() {Id=3, Nombre="Mikel", Apellidos="Oyarzabal", Direccion="Calle del Terror", FechaNac="27/03/1980", ImageURL="https://thispersondoesnotexist.com/", Telefono=698574635},
                new clsPersona() {Id=4, Nombre="Nicolás", Apellidos="Williams", Direccion="Calle del Terror", FechaNac="27/03/1999", ImageURL="https://thispersondoesnotexist.com/", Telefono=622345789},
                new clsPersona() {Id=5, Nombre="Joselu", Apellidos="Que Barbaridad", Direccion="Calle del Terror", FechaNac="27/03/1988", ImageURL="https://thispersondoesnotexist.com/", Telefono=601987654},
                new clsPersona() {Id=6, Nombre="Alejandro", Apellidos="Grimaldo", Direccion="Calle del Terror", FechaNac="27/03/1977", ImageURL="https://thispersondoesnotexist.com/", Telefono=611872634},
                new clsPersona() {Id=7, Nombre="Pedri", Apellidos="González", Direccion="Calle del Terror", FechaNac="27/03/1985", ImageURL="https://thispersondoesnotexist.com/", Telefono=631276398},
                new clsPersona() {Id=8, Nombre="Rodri", Apellidos="Hernández", Direccion="Calle del Terror", FechaNac="27/03/1990", ImageURL="https://thispersondoesnotexist.com/", Telefono=641987654},
                new clsPersona() {Id=9, Nombre="Pablo", Apellidos="Gavi", Direccion="Calle del Terror", FechaNac="27/03/1993", ImageURL="https://thispersondoesnotexist.com/", Telefono=644409876 }
            };
            return listaPersonas;
        }
    }
}
