using bibliotecaEj3;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ej3_U9_DesarrolloInterfaces.Models.ViewModels
{
    public class clsPersonaVM : INotifyPropertyChanged
    {
        #region atributos
        private clsPersona persona = new clsPersona();
        private string nombre;
        #endregion

        #region constructores
        public clsPersonaVM() {
            nombre = "Paco";
            persona.Nombre = nombre;
        }
        public clsPersonaVM (string nombre)
        {
            persona.Nombre = nombre;   
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return persona.Nombre; }
            set { persona.Nombre = value;
                OnPropertyChanged();
            }
        }
        public clsPersona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string atributo = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }
    }
}
