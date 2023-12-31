﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ej2_U9_DesarrolloInterfaces.Models
{
    public class clsPersona: INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        private string apellidos;
        private int id;
        #endregion

        #region constructores
        public clsPersona() {
            nombre = "Paco";
        }

        public clsPersona(int id, string nombre, string apellidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value;}
        }

        private void OnPropertyChanged([CallerMemberName] string atributo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}