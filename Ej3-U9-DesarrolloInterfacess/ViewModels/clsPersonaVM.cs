using bibliotecaEj3;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ej3_U9_DesarrolloInterfaces.Models.ViewModels
{
    public class clsPersonaVM : INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        #endregion

        #region constructores
        public clsPersonaVM() {
            nombre = "Paco";
        }
        public clsPersonaVM (string nombre)
        {
            this.nombre = nombre;   
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string atributo = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }
    }
}
