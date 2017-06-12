using System.Text;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta que hereda de la clase 'Persona' y contiene el
    /// legajo del universitario.
    /// Puede comparar si dos universitarios son iguales y
    /// mostrar los datos del universitario.
    /// </summary>
    public abstract class Universitario:Persona
    {
        #region Atributos
        /// <summary>
        /// Legajo del universitario.
        /// </summary>
        protected int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Universitario() { }

        /// <summary>
        /// Constructor que establece los valores de los atributos
        /// </summary>
        /// <param name="legajo">Legajo del Universitario.</param>
        /// <param name="nombre">Nombre del Universitario.</param>
        /// <param name="apellido">Apellido del Universitario.</param>
        /// <param name="dni">DNI del Universitario.</param>
        /// <param name="nacionalidad">Nacionalidad del Universitario.</param>
        public Universitario(int legajo,string nombre,string apellido,string dni,
            ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve los datos del universitario.
        /// </summary>
        /// <returns>Datos del universitario.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            return sb.ToString(); 
        }
        /// <summary>
        /// Retorna una cadena con la clase que toma o asiste.
        /// </summary>
        /// <returns>clase</returns>
        protected abstract string ParticiparEnClase();
        #endregion

        #region Sobrecargas
        /// <summary>
        /// indica si es igual al objeto.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>Retorna true si son iguales y false si son distintos.</returns>
        public override bool Equals(object obj)
        {
            return ((Universitario)obj == this);
        }

        /// <summary>
        /// Verifica si son el mismo universitario comparando legajo y DNI.
        /// </summary>
        /// <param name="pg1">Primer universitario a comparar.</param>
        /// <param name="pg2">Segundo universitario a comparar.</param>
        /// <returns>Retorna true si son iguales y false si son distintos</returns>
        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            return (pg1.DNI == pg2.DNI && pg1.legajo == pg2.legajo && pg1 is Universitario && pg2 is Universitario);
        }

        /// <summary>
        /// Verifica si no son el mismo universitario comparando legajo y DNI.
        /// </summary>
        /// <param name="pg1">Primer universitario a comparar.</param>
        /// <param name="pg2">Segundo universitario a comparar.</param>
        /// <returns>Retorna true si son distintos y false si son iguales</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
