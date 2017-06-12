using System;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verifica que un alumno no
    /// estee en una lista.
    /// </summary>
    public class AlumnoRepetidoException:Exception
    {
        public AlumnoRepetidoException(string messaje) : base(messaje) { }
    }
}
