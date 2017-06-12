using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Clase que contiene todos los alumnos, profesores y clases de la universidad.
    /// Puede guardar los datos de una universidad een un archivo XML y leerlos del mismo.
    /// Puede agregar alumnos, profesores y clases a la universidad.
    /// Puede comparar alumnos, profesores y clases con la universidad.
    /// </summary>
    public class Universidad
    {
        #region Atributos y propiedades
        /// <summary>
        /// Lista que contiene alumnos.
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
        /// Lista que contiene jornadas.
        /// </summary>
        private List<Jornada> _jornada;
        /// <summary>
        /// Permite acceder a la lista de jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return this._jornada; }
            set { this._jornada = value; }
        }

        /// <summary>
        /// Lista que contiene profesores.
        /// </summary>
        private List<Profesor> _profesores;
        /// <summary>
        /// Permite acceder a la lista de profesores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this._profesores; }
            set { this._profesores = value; }
        }
        /// <summary>
        /// Permite agregar una jornada en la posicion indicada.
        /// </summary>
        /// <param name="i">Posicion.</param>
        /// <returns>Jornada.</returns>
        public Jornada this[int i]
        {
            get { return this._jornada[i]; }
            set { this._jornada[i] = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto que instancia la lista de alumnos.
        /// </summary>
        public Universidad()
        {
            this._alumnos = new List<Alumno>();
            this._profesores = new List<Profesor>();
            this._jornada = new List<Jornada>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Concatena los datos de la universidad.
        /// </summary>
        /// <param name="gim">Universidad.</param>
        /// <returns>Datos de la universidad.</returns>
        private string MostrarDatos(Universidad gim)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jornada:");
            foreach (Jornada item in this._jornada)
                sb.AppendLine(item.Leer());

            return sb.ToString();
        }

        /// <summary>
        /// Guarda los datos de la u niversidad en un archivo XML.
        /// </summary>
        /// <param name="gim">Universidad.</param>
        public static void Guardar(Universidad gim)
        {
            XmlSerializer XmlS = new XmlSerializer(typeof(Universidad));
            try
            {                
                using (StreamWriter sw = new StreamWriter("Universidad.xml"))
                    XmlS.Serialize(sw, gim);
            }
            catch (ArchivosException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lee los datos de la universidad de un archivo.
        /// </summary>
        /// <returns>Universidad.</returns>
        public Universidad Leer()
        {
            XmlSerializer XmlS = new XmlSerializer(typeof(Universidad));
            try
            {
                using (StreamReader sr = new StreamReader("Universidad.xml"))
                    return (Universidad)XmlS.Deserialize(sr);
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verifica que un alumno pertenezca a una universidad.
        /// </summary>
        /// <param name="g">Univervsidad</param>
        /// <param name="a">Alumno.</param>
        /// <returns>Devolvera true si pertenece y false si no pertenece.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g._alumnos)
            {
                if (item==a)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que un alumno no pertenezca a una universidad.
        /// </summary>
        /// <param name="g">Univervsidad</param>
        /// <param name="a">Alumno.</param>
        /// <returns>Devolvera true si no pertenece y false si pertenece.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Verifica que haya un profesor que de determinada clase.
        /// </summary>
        /// <param name="g">Univervsidad.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>Devolvera true si hay un profesor que de la clase o arrojara
        /// una excepcion si no hay ningun profesor que de la clase.</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach (Profesor item in g._profesores)
            {
                if (item==clase)
                    return item;
            }
            throw new SinProfesorException("No hay profesor para la clase.");
        }

        /// <summary>
        /// Verifica que haya un profesor que no de determinada clase.
        /// </summary>
        /// <param name="g">Univervsidad.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>Devolvera true si hay un profesor que no de la clase o
        /// arrojara una excepcion si no hay un profesor q ue no de la clase.</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor item in g._profesores)
            {
                if (item != clase)
                    return item;
            }
            throw new SinProfesorException("No hay profesor que no de la clase.");
           
        }
        /// <summary>
        /// Verifica que un profesor pertenezca a una universidad.
        /// </summary>
        /// <param name="g">Univervsidad</param>
        /// <param name="i">Profesor.</param>
        /// <returns>Devolvera true si pertenece y false si no pertenece.</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor item in g._profesores)
            {
                if (item == i)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que un profesor no pertenezca a una universidad.
        /// </summary>
        /// <param name="g">Univervsidad</param>
        /// <param name="i">Profesor.</param>
        /// <returns>Devolvera true si no pertenece y false si pertenece.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Agrega un alumno a la universidad si este no esta ya en ella.
        /// </summary>
        /// <param name="g">Universidad.</param>
        /// <param name="a">Alumno.</param>
        /// <returns>Universidad con el alumno agregado y si el alumno esta
        /// repetido se arrojara una excepcion.</returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g._alumnos.Add(a);
                return g;
            }
            else     
                throw new AlumnoRepetidoException("Alumno repetido.");                
        }
        /// <summary>
        /// Agrega una clase junto con un profesor que puede dar la clase
        /// y sus alumnos a una nueva jornada de la universidad.
        /// </summary>
        /// <param name="g">Universidad.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>Devuelve la universidad con la clase agregada.</returns>
        public static Universidad operator +(Universidad g, Universidad.EClases clase)
        {
            Profesor inst;
            try
            {
                inst = g == clase;
                Jornada j = new Jornada(clase, inst);
                foreach (Alumno item in g._alumnos)
                {
                    if (item == clase)
                        j = j + item;
                }
                g._jornada.Add(j);
            }
            catch (SinProfesorException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return g;            
        }

        /// <summary>
        /// Agrega un profesor a la universidad si este no esta ya en ella.
        /// </summary>
        /// <param name="g">Universidad.</param>
        /// <param name="i">Profesor.</param>
        /// <returns>Universidad con el profesor ya agregado.</returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
                g._profesores.Add(i);

            return g;
        }
        #endregion

        #region Implementaciones
        /// <summary>
        /// Hace publicos los datos de la universidad.
        /// </summary>
        /// <returns>Datos de la universidad.</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        #endregion

        #region Enumerado
        /// <summary>
        /// Enumerado con las clases.
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD,
        }
        #endregion

    }

}
