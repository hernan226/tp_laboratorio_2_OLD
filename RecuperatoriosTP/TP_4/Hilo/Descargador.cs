using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public delegate void ProgresoDescarga(int progreso);
    public delegate void DescargaCompleta(string html);

    public class Descargador
    {
        private string html;
        private Uri direccion;

        public ProgresoDescarga PDescarga;
        public DescargaCompleta DCompleta;

        public Descargador(Uri direccion)
        {
            this.direccion = direccion;
            this.html = direccion.AbsolutePath;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;

                cliente.DownloadStringAsync(direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.PDescarga(e.ProgressPercentage);
        }
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            this.DCompleta(e.Result);
        }
    }
}
