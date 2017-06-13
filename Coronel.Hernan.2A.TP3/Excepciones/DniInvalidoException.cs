using System;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que verifica que un dni sea mayor a cero.
    /// </summary>
    public class DniInvalidoException:Exception
    {
        public static string mensajeBase="DNI invalido.";

        public DniInvalidoException() : base(mensajeBase) { }

        public DniInvalidoException(Exception e) : base(mensajeBase, e) { }

        public DniInvalidoException(string messaje) : base(messaje) { }

        public DniInvalidoException(string messaje, Exception e) : base(messaje, e) { }

    }
}
