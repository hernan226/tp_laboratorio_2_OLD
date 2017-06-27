using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string _Archivo;

        public Texto(string archivo)
        {
            this._Archivo = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this._Archivo, true))
                    sw.WriteLine(datos);

                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool leer(out List<string> datos)
        {
            datos = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(this._Archivo))
                {
                    while (!sr.EndOfStream)
                    {
                        datos.Add(sr.ReadLine());
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
