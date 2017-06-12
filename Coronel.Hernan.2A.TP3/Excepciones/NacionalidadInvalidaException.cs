using System;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verifica que un dni sea valido
    /// para su nacionalidad.
    /// </summary>
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException() : base() { }

        public NacionalidadInvalidaException(string messaje) : base(messaje) { }
    }
}
