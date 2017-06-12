using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    /// <summary>
    /// Verifica que el DNI sea mayor a cero.
    /// </summary>
    [TestClass]
    public class TestDniValidoException
    {
        [TestMethod]
        public void TestDNI()
        {
            Alumno TestAlumno;

            try
            {
                TestAlumno = new Alumno(1, "test", "test", "-123",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino,
            Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
                Assert.Fail();
            }
            catch (DniInvalidoException)
            {
                //Validado con exito
            }
        }
    }
}
