using Excepciones;
using System;
using System.Text;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta que contiene los datos basicos de una persona
    /// (nombre, apellido, DNI, nacionalidad).
    /// Puede mostrar los datos de la persona.
    /// </summary>
    public abstract class Persona
    {
        #region Atributos y propiedades
        /// <summary>
        /// DNI de la persona.
        /// </summary>
        private int _dni;
        /// <summary>
        /// Permite acceder al DNI del alumno y arroja una
        /// excepcion si es un DNI invalido.
        /// </summary>
        public int DNI
        {
            get { return this._dni; }
            set
            {
                try
                {
                    this._dni = ValidarDni(this._nacionalidad, value);
                }
                catch (DniInvalidoException ex)
                {
                    throw new DniInvalidoException(ex.Message);
                }
                catch (NacionalidadInvalidaException ex)
                {
                    throw new NacionalidadInvalidaException(ex.Message);
                }
            }
        }
        /// <summary>
        /// Establece el DNI a partir de un string y
        /// arroja una excepcion si es un DNI invalido.
        /// </summary>
        public string StringToDNI
        {
            set
            {
                try
                {
                    this._dni = ValidarDni(this._nacionalidad, value);
                }
                catch (DniInvalidoException ex)
                {
                    throw new DniInvalidoException(ex.Message);
                }
                catch (NacionalidadInvalidaException ex)
                {
                    throw new NacionalidadInvalidaException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        private string _nombre;
        /// <summary>
        /// Permite acceder al nombre del alumno.
        /// </summary>
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        /// <summary>
        /// Apellido de la persona.
        /// </summary>
        private string _apellido;
        /// <summary>
        /// Permite acceder al apellido del alumno.
        /// </summary>
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        /// <summary>
        /// Nacionalidad de la persona.
        /// </summary>
        private ENacionalidad _nacionalidad;
        /// <summary>
        /// Permite acceder a la nacionalidad del alumno.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Persona(){ }
        /// <summary>
        /// Asigna valores a los atributos.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            if (apellido == null)
                throw new NullReferenceException("Apellido nulo.");
            this._apellido = apellido;
            if (nombre == null)
                throw new NullReferenceException("Nombre nulo.");
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Asigna valores a los atributos.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona en formato de numero.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Asigna valores a los atributos.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona en formato de palabra.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// sobrecarga el metodo ToString() para enviar los datos de la persona.
        /// </summary>
        /// <returns>Datos de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre completo: " + this._nombre);
            sb.Append(", " + this._apellido);
            sb.AppendLine("\nNacionalidad: " + this._nacionalidad+"\n");
            //sb.AppendLine("DNI: " + this._Dni);

            return sb.ToString();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Verifica si el dni es valido para su respectiva nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// <param name="dato">DNI de la persona en formato numero.</param>
        /// <returns>DNI valido.</returns>
        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato < 89999999)
                    return dato;
                else
                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI.");
            }
            else if (dato > 89999999)
                return dato;
            else
                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI.");

            
        }
        /// <summary>
        /// Verifica si el dni es un numero valido para su respectiva nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// <param name="dato">DNI de la persona en formato palabra.</param>
        /// <returns>Numero valido como DNI.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (int.TryParse(dato, out dni))
                if (dni > 0)
                    return this.ValidarDni(nacionalidad, dni);

            throw new DniInvalidoException("El DNI no es un numero valido.");
        }
        #endregion

        #region Enumerado
        /// <summary>
        /// Enumerado que contiene las nacionalidades.
        /// </summary>
        public enum ENacionalidad 
        {           
            Argentino,
            Extranjero
        }
        #endregion
    }
}
