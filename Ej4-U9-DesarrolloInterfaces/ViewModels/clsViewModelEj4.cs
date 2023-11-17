using System.ComponentModel;
using System.Runtime.CompilerServices;
using bibliotecaEj3;

namespace Ej4_U9_DesarrolloInterfaces.ViewModels
{
    public class clsViewModelEj4 : INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        private string apellidos;
        #endregion

        #region constructores
        public clsViewModelEj4(){}
        public clsViewModelEj4(string nombre, string apellidos)
        {
            this.apellidos = apellidos;
            this.nombre = nombre;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
  
                if (nombre.EndsWith("n") || nombre.EndsWith("N")) 
                {
                    apellidos = string.Empty;
                    OnPropertyChanged("Apellidos");
                }
            }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                if (apellidos.EndsWith("n") || apellidos.EndsWith("N"))
                {
                    nombre = string.Empty;
                    OnPropertyChanged("Nombre");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string atributo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }
        #endregion
    }
}
