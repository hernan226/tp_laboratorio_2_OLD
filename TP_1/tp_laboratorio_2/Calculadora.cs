using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_laboratorio_2
{
    class Calculadora
    {
        /// <summary>
        /// Opera entre los valores recibidos por parámetro según que operador fue recibido por parámetro.
        /// </summary>
        /// <param name="numero1">Numero número a operar.</param>
        /// <param name="numero2">Numero número a operar.</param>
        /// <param name="operador">string operador("+", "-", "*", "/").</param>
        /// <returns>Retorna el resultado de la operación especificada.</returns>
        public double operar(Numero numero1, Numero numero2, string operador)
        {
            if (validarOperador(operador) == "+")
                return numero1.numero + numero2.numero;

            if (validarOperador(operador) == "-")
                return numero1.numero - numero2.numero;

            if (validarOperador(operador) == "*")
                return numero1.numero * numero2.numero;

            if (validarOperador(operador) == "/" && numero2.numero != 0)
                return numero1.numero / numero2.numero;

            return 0;
        }
        /// <summary>
        /// Verifica que el operador ingresado sea correcto.
        /// </summary>
        /// <param name="operador">string operador a validar.</param>
        /// <returns>Retorna "+" en caso de error. Retorna el operador si no hubo error.</returns>
        public string validarOperador(string operador)
        {
            if (operador=="-")
            return "-";

            if (operador=="*")
            return "*";

            if (operador=="/")
            return "/";

            return "+";
            
        }
        
    }
}
