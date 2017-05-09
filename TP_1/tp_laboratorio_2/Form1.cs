using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_laboratorio_2
{
    public partial class FrmPrincipal : Form
    {
        

        Calculadora miCalcu= new Calculadora();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(TxtNumero.Text);
            Numero numero2 = new Numero(TxtNumero2.Text);
            string operador = CmbOperacion.Text;

            LblResultado.Text = "" + miCalcu.operar(numero1, numero2, operador);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumero.Text = "";
            TxtNumero2.Text = "";
            CmbOperacion.Text = "";
            LblResultado.Text = "0";  

        }
    }
}
