using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    /// <summary>
    /// Verifica que el nombre y apellido de una persona no sean nulos.
    /// </summary>
    [TestClass]
    public class TestNombreYApellidoNulos
    {
        /// <summary>
        /// Verifica que el nombre no sea nulo.
        /// </summary>
        [TestMethod]
        public void TestNombre()
        {
            Alumno TestAlumno;

            try
            {
                TestAlumno = new Alumno(1, null, "test", "123",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino,
            Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
                Assert.Fail();
            }
            catch (NullReferenceException)
            {
                //Validado con exito
            }

        }

        /// <summary>
        /// Verifica que el apellido no sea nulo.
        /// </summary>
        [TestMethod]
        public void TestApellido()
        {
            Alumno TestAlumno;

            try
            {
                TestAlumno = new Alumno(1, "test", null, "123",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino,
            Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
                Assert.Fail();
            }
            catch (NullReferenceException)
            {
                //Validado con exito
            }

        }
    }
}
