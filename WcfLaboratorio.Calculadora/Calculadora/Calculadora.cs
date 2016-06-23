using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.ServiceReferenceCalculadora;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            //ServiceReferenceCalculadora
            ServiceReferenceCalculadora.MiCalculadoraClient client = new
            ServiceReferenceCalculadora.MiCalculadoraClient();
            string returnString;

            returnString = client.RealizarOperacionBinaria(Convert.ToChar(cbOperador.Text),txtNumero2.Text,cbBase1.Text,cbBase1.Text);
            lblResultado.Text = returnString;
        }
    }
}
