namespace bibliotecaEj3
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellidos;
        private string fechaNac;
        private string direccion;
        private long telefono;
        private string imageURL;
        private int id;
        #endregion

        #region constructores
        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public clsPersona(int id, string nombre, string apellidos, string fechaNac, long telefono, string imageURL, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.fechaNac = fechaNac;
            this.telefono = telefono;
            this.imageURL = imageURL;
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
                nombre = value;
            }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }
        #endregion
    }
}