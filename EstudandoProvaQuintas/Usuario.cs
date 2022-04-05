using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoProvaQuintas
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }

        public Usuario(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}
