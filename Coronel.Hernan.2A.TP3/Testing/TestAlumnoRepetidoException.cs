using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    /// <summary>
    /// Comprueba que no se pueda repetir un
    /// alumno en una universidad.
    /// </summary>
    [TestClass]
    public class TestAlumnoRepetidoException
    {
        [TestMethod]
        public void TestAlumnoRepetido()
        {
            Universidad uni = new Universidad();

            Alumno alu1 = new Alumno(1, "test", "test", "123",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino,
            Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            uni += alu1;

            try
            {                
                uni += new Alumno(1, "test", "test", "123",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
                Assert.Fail();
            }
            catch (AlumnoRepetidoException)
            {
                //Validado con exito
            }
        }
    }
}
