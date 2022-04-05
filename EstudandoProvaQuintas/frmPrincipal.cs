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
    public partial class frmPrincipal : Form
    {
        Conta ContaAtual { get; set; }
        List<Conta> ContaList = new List<Conta>();
        public frmPrincipal()
        {
            InitializeComponent();
            ContaList.Add(new Conta("1234", new Usuario("Harry Styles", "123.456.789-00"), "louis123", "harryzinho@cupcake.com"));
            ContaList.Add(new Conta("4321", new Usuario("Niall Horan", "987.654.321-11"), "liam321", "niallzinho@reidelas.com"));
        }

        public void AtualizarTela()
        {
            lblNomeUsuario.Text = ContaAtual.Titular.Nome;
            lblPIX.Text = ContaAtual.PIX;
            lblSaldo.Text = ContaAtual.Saldo.ToString();

            lstExtrato.Items.Clear();
            foreach(String log in ContaAtual.Logs)
            {
                lstExtrato.Items.Add(log);
            }
        }

        public bool Login()
        {
            while (ContaAtual == null)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                foreach (Conta Conta in ContaList)
                {
                    if (Conta.Numero == login.Numero && Conta.SenhaCorreta(login.Senha))
                    {
                        ContaAtual = Conta;
                        AtualizarTela();
                        return true;
                    }
                }
            }
          return false;
        }
        


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            frmDepositar Depositar = new frmDepositar();
            Depositar.ShowDialog();
            if(Depositar.valor > 0)
            {
                ContaAtual.Deposito(Depositar.valor);
                this.AtualizarTela();
            }
        }
        private void btnSacar_Click(object sender, EventArgs e)
        { 
          frmSacar Sacar = new frmSacar();
           Sacar.ShowDialog();
            if(Sacar.valor > 0 && ContaAtual.Saldo >= Sacar.valor)
            {
                ContaAtual.Saque(Sacar.valor);
                this.AtualizarTela();
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            frmTransferir Transferir = new frmTransferir();
            Transferir.ShowDialog();
            if(Transferir.Valor > 0 && Transferir.NumeroConta != null)
            {
                foreach(Conta conta in ContaList)
                {
                    if (Transferir.NumeroConta == conta.Numero)
                    {
                        ContaAtual.Transferencia(conta, Transferir.Valor);
                        break;
                    }
                }
                this.AtualizarTela();
            }

        }

        private void lblPIX_Click(object sender, EventArgs e)
        {
            ContaAtual = null;
            this.Login();
        }
    }
}
