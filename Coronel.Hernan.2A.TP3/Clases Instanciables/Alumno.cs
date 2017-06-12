using EntidadesAbstractas;
using System.Text;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Clase que hereda de la clase 'Universitario',
    /// contiene la clase que toma el alumno y el estado de su cuenta.
    /// Puede mostrar los datos del alumno y verifica que un alumno
    /// estee en una clase.
    /// </summary>
    public sealed class Alumno:Universitario
    {
        #region Atributos
        /// <summary>
        /// Clase que toma el alumno.
        /// </summary>
        private Universidad.EClases _claseQueToma;
        /// <summary>
        /// Estado de la cuenta del alumno.
        /// </summary>
        private EEstadoCuenta _estadoCuenta;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno() { }

        /// <summary>
        /// Establece los datos del alumno.
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">Clase que toma el alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni,
            ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Establece los datos del alumno.
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">Clase que toma el alumno.</param>
        /// <param name="estadoDeCuenta">Estado de la cuenta del alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni,
            ENacionalidad nacionalidad, Universidad.EClases claseQueToma,
            EEstadoCuenta estadoDeCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoDeCuenta;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Verifica que un alumno pertenezca a una clase dependiendo de su estado de cuenta.
        /// </summary>
        /// <param name="a">Alumno a verificar.</param>
        /// <param name="clase">Clase a la que puede pertenecer el alumno.</param>
        /// <returns>Retorna true si el alumno esta en esa clase y false si no esta en ella.</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor);
        }
        /// <summary>
        /// Verifica que un alumno no pertenezca a una clase dependiendo de su estado de cuenta.
        /// </summary>
        /// <param name="a">Alumno a verificar.</param>
        /// <param name="clase">Clase a la que puede pertenecer el alumno.</param>
        /// <returns>Retorna true si el alumno no esta en esa clase y false si esta en ella.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a._claseQueToma != clase);
        }
        #endregion

        #region Implementaciones
        /// <summary>
        /// Retorna los datos del alumno.
        /// </summary>
        /// <returns>Datos del alumno.</returns>
        protected override string MostrarDatos()
        {
            return this.ToString();
        }

        /// <summary>
        /// Retorna la cadena "Toma  clases de: " junto al nombre de la clase que toma.
        /// </summary>
        /// <returns>"Toma  clases de: " junto al nombre de la clase que toma.</returns>
        protected override string ParticiparEnClase()
        {
            return ("Toma clases de: " + this._claseQueToma);
        }

        /// <summary>
        /// Concatena los datos del alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("Legajo número: " + this.legajo+"\n");
            sb.AppendLine("Estado de cuenta: " + this._estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        #endregion

        #region Enumerado
        /// <summary>
        /// Enumeado que indica si la persona tiene la cuenta al dia, endeudada o si esta becado.
        /// </summary>
        public enum EEstadoCuenta
        {
            Deudor,
            Becado,
            AlDia
        }
        #endregion
    }
}
