using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesInstanciables;
using EntidadesAbstractas;
using System.IO;
using Excepciones;

namespace Testing
{
    /// <summary>
    /// Verifica que el DNI coresponda a la nacionalidad.
    /// </summary>
    [TestClass]
    public class TestNacionalidadInvalidaException
    {
        /// <summary>
        /// Verifica que el DNI pertenezca a un argentino\a
        /// </summary>
        [TestMethod]
        public void TestNacionalidadInvalidaLocal()
        {
            Alumno TestPersona;
            try
            {
                TestPersona = new Alumno(1,"test","test","123",
                EntidadesAbstractas.Persona.ENacionalidad.Extranjero,
                Universidad.EClases.Laboratorio,Alumno.EEstadoCuenta.AlDia);

                Assert.Fail();
            }
            catch (NacionalidadInvalidaException)
            {
                //Validado con exito
            }
        }

        /// <summary>
        /// Verifica que el DNI pertenezca a un extranjero\a
        /// </summary>
        [TestMethod]
        public void TestNacionalidadInvalidaExtranjero()
        {
            Alumno TestPersona;
            try
            {
                TestPersona = new Alumno(1, "test", "test", "90000000",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

                Assert.Fail();
            }
            catch (NacionalidadInvalidaException)
            {
                //Validado con exito
            }
        }
    }
}
