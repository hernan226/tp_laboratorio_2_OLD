using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_laboratorio_2
{
    class Numero
    {
        public double numero;

        /// <summary>
        /// Constructor por defecto inicializa el atributo numero en 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// recibe un número de coma flotante de doble presición y lo cargará en el atributo numero.
        /// </summary>
        /// <param name="dNumero">double número a cargar en el atributo.</param>
        public Numero(double dNumero)
        {
            this.numero = dNumero;
        }
        /// <summary>
        /// Verifica que el string recibido sea un número válido.
        /// </summary>
        /// <param name="sNumero">string del número a validar.</param>
        public Numero(string sNumero)
        {
            SetNumero(sNumero);
        }

        /// <summary>
        /// Retorna el valor del atributo numero.
        /// </summary>
        /// <returns>double valor del atributo.</returns>
        public double GetNumero()
        {
            return this.numero;
        }
        /// <summary>
        /// llama a la función ValidarNumero y comprueba si es un número válido.
        /// </summary>
        /// <param name="sNumero">string número a validar.</param>
        private void SetNumero(string sNumero) 
        {
            this.numero = ValidarNumero(sNumero);
        }
        /// <summary>
        /// Valida si es un número.
        /// </summary>
        /// <param name="numeroString">string a valida.r</param>
        /// <returns>Retorna cero si no es un número válido. Retorna el número convertido a coma flotante de doble presición si es válido.</returns>
        private double ValidarNumero(string numeroString)
        {
            double num;
            if (double.TryParse(numeroString, out num))
                return num;
            else
                return 0;

        }

    }
}
