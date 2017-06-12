using Excepciones;
using System;
using System.IO;
using System.Text;

namespace Archivos
{
    /// <summary>
    /// Guarda los datos de una universidad en 
    /// un archivo de texto o lee de un archivo
    /// de texto los datos de una universidad y
    /// la escribe en pantalla.
    /// </summary>
    public class Texto:IArchivo<string>
    {
        /// <summary>
        /// Guarda en un archivo de texto los datos recibidos
        /// por parametro
        /// </summary>
        /// <param name="archivos">Direccion del archivo.</param>
        /// <param name="datos">Datos a guardar en
        /// el archivo</param>
        /// <returns>Devuelve true si pudo guardar los datos y
        /// arroja una excepcion si no pudo</returns>
        public bool guardar(string archivos, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivos,true))
                    sw.WriteLine(datos);

                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        /// <summary>
        /// Lee de un archivo de texto y lo imprime por pantalla.
        /// </summary>
        /// <param name="archivos">Direccion del archivo.</param>
        /// <param name="datos">Datos que contenia el archivo</param>
        /// <returns>retorna true si pude leer y arroja una excepcion
        /// en caso de que no se haya podido.</returns>
        public bool leer(string archivos, out string datos)
        {
            string Recuperado;
            StringBuilder sb = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(archivos))
                {
                    while ((Recuperado = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(Recuperado);
                    }
                }

                datos = sb.ToString();

                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
    }
}
