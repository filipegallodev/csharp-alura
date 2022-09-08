using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        private int _funcao;

        public Funcionario(string nome, string cpf, double salario, int _funcao)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            this._funcao = _funcao;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        //public int Funcao { get; set; }

        public double Bonificacao
        {
            get
            {
                if (_funcao == 1)
                {
                    return Salario;
                }
                else
                {
                    return Salario *= 0.1;
                }
            }

        }
    }
}
