using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double Bonificacao
        {
            get => Salario *= 0.1;
        }
    }
}
