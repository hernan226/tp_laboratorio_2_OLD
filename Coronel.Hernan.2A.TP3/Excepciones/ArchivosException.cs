using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verifica que no haya problemas en
    /// la creacion y escritura/lectura del archivo.
    /// </summary>
    public class ArchivosException:Exception
    {
        public ArchivosException(Exception innerException): base(innerException.InnerException.Message) { }     
    }
}
