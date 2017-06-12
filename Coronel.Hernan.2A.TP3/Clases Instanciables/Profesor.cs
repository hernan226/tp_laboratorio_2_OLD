using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Clase que hereda de la clase 'universidad',
    /// contiene las clases en las que participa el profesor en el dia y
    /// estas son elegidas aleatoreamente.
    /// Puede mostrar los datos del profesor y puede verificar que el
    /// profesor pertenezca a una clase.
    /// </summary>
    public sealed class Profesor:Universitario
    {
        #region Atributos
        /// <summary>
        /// Cola de clases del dia.
        /// </summary>
        private Queue<Universidad.EClases> _clasesDelDia;
        /// <summary>
        /// Clase que tomara el profesor.
        /// </summary>
        private static Random _random;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Profesor() { }

        /// <summary>
        /// Constructor estatico que inicializa el atributo del tipo Random.
        /// </summary>
        static Profesor()
        {
            Profesor._random = new Random();
        }

        /// <summary>
        /// Establece los datos del profesor e inicializa el atributo del tipo Queue.
        /// </summary>
        /// <param name="id">Legajo del profesor.</param>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="apellido">Apellido del profesor.</param>
        /// <param name="dni">DNI del profesor.</param>
        /// <param name="nacionalidad">Nacionalidad del profesor.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._RandomClases();
        }
        #endregion

        #region Metodos
        private void _RandomClases()
        {
            this._clasesDelDia.Enqueue((Universidad.EClases)_random.Next(0, 4));
            this._clasesDelDia.Enqueue((Universidad.EClases)_random.Next(0, 4));            
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verifica que un profesor pertenezca a una clase.
        /// </summary>
        /// <param name="i">Profesor a verificar.</param>
        /// <param name="clase">Clase a la que puede pertenecer el profesor.</param>
        /// <returns>Retorna true si el profesor esta en esa clase y false si no esta en ella.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i._clasesDelDia)
            {
                if (item==clase)
                    return true;
            }
            return false;
            
        }
        /// <summary>
        /// Verifica que un profesor no pertenezca a una clase.
        /// </summary>
        /// <param name="i">Profesor a verificar.</param>
        /// <param name="clase">Clase a la que puede pertenecer el profesor.</param>
        /// <returns>Retorna true si el profesor no esta en esa clase y false si esta en ella.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
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
        /// Retorna la cadena "Clases del dia: " junto al nombre de las clases en que participa.
        /// </summary>
        /// <returns>"Clases del dia: " junto al nombre de la clase que toma.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Clases del día: ");
            foreach (Universidad.EClases item in this._clasesDelDia)
            {
                sb.AppendLine("" + item);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Concatena los datos del Profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine("Legajo número: " + this.legajo);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        #endregion

    }
}
