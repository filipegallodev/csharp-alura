using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class Bonificacao
    {
        public double TotalBonificacao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.Bonificacao;
        }
        public void Registrar(Diretor diretor)
        {
            TotalBonificacao += diretor.Bonificacao;
        }
    }
}
