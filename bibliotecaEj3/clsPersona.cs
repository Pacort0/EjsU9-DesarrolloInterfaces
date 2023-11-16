namespace bibliotecaEj3
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellidos;
        private int id;
        #endregion

        #region constructores
        public clsPersona()
        {
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
            set
            {
                nombre = value;}
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        #endregion
    }
}