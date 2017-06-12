using System;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verifica que no haya problemas en
    /// la creacion y escritura/lectura del archivo.
    /// </summary>
    public class ArchivosException:Exception
    {
        public ArchivosException(Exception innerException)
            : base(innerException.Message, innerException) { }     
    }
}
