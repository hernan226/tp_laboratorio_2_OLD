using EntidadesInstanciables;
using Excepciones;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    /// <summary>
    /// Guarda o lee una universidad en un archivo XML.
    /// </summary>
    /// <typeparam name="T">El tipo de dato que recibe.</typeparam>
    public class Xml<T>:IArchivo<T>
    {
        /// <summary>
        /// Guarda una universidad en un archivo XML.
        /// </summary>
        /// <param name="archivos">Direccion del archivo.</param>
        /// <param name="datos">Universidad recibida.</param>
        /// <returns>Devuelve true si pudo guardar o arroja una
        /// excepcion si no pudo.</returns>
        public bool guardar(string archivos, T datos)
        {
            XmlSerializer XmlS = new XmlSerializer(typeof(Universidad));
            try
            {
                using (StreamWriter sw = new StreamWriter(archivos,true))
                    XmlS.Serialize(sw, datos);
                return true;
            }
            catch (ArchivosException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lee de un archivo XML los datos de una universidad
        /// y los devuelve por out.
        /// </summary>
        /// <param name="archivos">Direccion del archivo.</param>
        /// <param name="datos">Salida de la universidad.</param>
        /// <returns>Devuelve true si leyo con exito o lanza una
        /// excepcion si no pudo</returns>
        public bool leer(string archivos, out T datos)
        {
            XmlSerializer XmlS = new XmlSerializer(typeof(Universidad));
            try
            {
                using (StreamReader sr = new StreamReader(archivos))
                    datos = (T)XmlS.Deserialize(sr);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
    }
}
