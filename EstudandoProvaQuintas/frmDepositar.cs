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
    public partial class frmDepositar : Form
    {
        public double valor { get; private set; }
        public frmDepositar()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            this.valor = Convert.ToDouble(txtValor.Text);
            this.Close();
        }
    }
}
