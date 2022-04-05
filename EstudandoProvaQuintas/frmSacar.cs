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
    public partial class frmSacar : Form
    {
        public double valor { get; private set; }
        public frmSacar()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            this.valor = Convert.ToDouble(txtValor.Text);
            this.Close();
        }
    }
}
