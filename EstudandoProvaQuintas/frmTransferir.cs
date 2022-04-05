using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudandoProvaQuintas
{
    public partial class frmTransferir : Form
    {
        public double Valor { get; private set; }
        public string NumeroConta { get; private set; }
        public frmTransferir()
        {
            InitializeComponent();
        }

        private void btnTranferir_Click(object sender, EventArgs e)
        {
            this.Valor = Convert.ToDouble(txtValor.Text);
            this.NumeroConta = txtNumeroConta.Text;
            this.Close();
        }
    }
}
