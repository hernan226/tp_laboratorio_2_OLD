using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Clase que contiene una lista de alumnos, la clase de la jornada, profesor de la jornada.
    /// Puede guardar los datos de la jornada en un archivo de texto, verificar si un alumno esta
    /// en la jornada y agregar un alumno a la jornada.
    /// </summary>
    public class Jornada
    {
        #region Atributos y propiedades
        /// <summary>
        /// Lista de alumnos.
        /// </summary>
        private List<Alumno> _alumnos;
        /// <summary>
        /// Permite acceder a la lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        /// <summary>
        /// Clase de la jornada.
        /// </summary>
        private Universidad.EClases _clase;
        /// <summary>
        /// Permite acceder a la clase de la jornada.
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        /// <summary>
        /// Instructor de la clase.
        /// </summary>
        private Profesor _instructor;
        /// <summary>
        /// Permite acceder al instructor de la clase.
        /// </summary>
        public Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto que inicializa la lista.
        /// </summary>
        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que establece los parametos de la jornada.
        /// </summary>
        /// <param name="clase">Clase de la jornada.</param>
        /// <param name="instructor">Instructor de la jornada.</param>
        public Jornada(Universidad.EClases clase,Profesor instructor)
            :this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Escribe en un archivo los datos de la jornada.
        /// </summary>
        /// <returns>Retornara true si lo realizo con exito, lanzara una excepcion si no lo logro y retornara false.</returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Jornada.txt"))
                    sw.WriteLine(jornada.Leer());

                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        /// <summary>
        /// Lee los datos de la jornada.
        /// </summary>
        /// <returns>Datos de la jornada.</returns>
        public string Leer()
        {
            return this.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Verifica que un alumno estee en la clase de la jornada.
        /// </summary>
        /// <param name="j">Jornada.</param>
        /// <param name="a">Alumno.</param>
        /// <returns>Devuelve true si el alumno esta en la clase y false si no esta en ella.</returns>
        public static bool operator ==(Jornada j,Alumno a)
        {
            foreach (Alumno item in j._alumnos)
            {
                if (item == a)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que un alumno estee en la clase de la jornada.
        /// </summary>
        /// <param name="j">Jornada.</param>
        /// <param name="a">Alumno.</param>
        /// <returns>Devuelve false si el alumno esta en la clase y true si no esta en ella.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Añade un alumno a la jornada si no esta en ella.
        /// </summary>
        /// <param name="j">Jornada.</param>
        /// <param name="a">Alumno.</param>
        /// <returns>La jornada con el alumno ya incluido.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j!=a)
            j._alumnos.Add(a);

            return j;
        }
        #endregion

        #region Implementaciones
        /// <summary>
        /// Concatena todos los datos de la jornada.
        /// </summary>
        /// <returns>Retorna todos los datos de la jornada.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Clase de " + this._clase + " por" + this._instructor.ToString());
            sb.Append("Alumnos: ");

            foreach (Alumno item in this._alumnos)
                sb.AppendLine(item.ToString());

            sb.Append("<------------------------------------------------>");

            return sb.ToString();
        }
        #endregion
    }
}
