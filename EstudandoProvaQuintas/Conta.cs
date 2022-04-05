using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoProvaQuintas
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Numero { get; private set; }
        public Usuario Titular { get; private set; }
        private string Senha { get; set; }
        public string PIX { get; private set; }
        public List<String> Logs { get; private set; }

        public Conta(string numero, Usuario Titular, string senha, string PIX)
        {
            this.Numero = numero;
            this.Titular = Titular;
            this.Senha = senha;
            this.PIX = PIX;
            this.Logs = new List<String>();
            this.Saldo = 0;
        }

        public bool SenhaCorreta(string senha)
        {
            return this.Senha.Equals(senha);
        }

        public void Log(string log)
        {
            Logs.Add(log);
        }

        public bool Deposito(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
                this.Log("Deposito de R$" + valor + ", realizado com sucesso!");
                return true;
            }
            else
            {
                this.Log("Não foi possivel realizar o deposito!");
                return false;
            }
        }

        public bool Saque(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                this.Log("Saque no valor de R$" + valor + ", realizado com sucesso!");
                return true;
            }
            else
            {
                this.Log("Não foi possível realizar o saque!");
                return false;
            }
        }

        public void ReceberTranferencia(Conta remetente, double valor)
        {
            this.Saldo += valor; 
            this.Log("Você recebeu R$" + valor + ", de " + remetente.Titular.Nome);
        }

        public bool Transferencia(Conta destinatorio, double valor)
        {
            if(valor > 0 && this.Saldo >= valor)
            {
                this.Saldo -= valor;
                this.Log("Você tranferiu R$" + valor + ", para " + destinatorio.Titular.Nome);
                destinatorio.ReceberTranferencia(this, valor);
                return true;
            }
            else
            {
                this.Log("Não foi possivel realizar essa transferencia");
                return false;
            }
        }
    }
}
