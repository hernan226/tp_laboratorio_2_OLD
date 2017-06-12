using System;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verficia que una universidad no
    /// tenga profesor para determinada clase.
    /// </summary>
    public class SinProfesorException:Exception
    {
        public SinProfesorException(string messaje) : base(messaje) { }
    }
}
