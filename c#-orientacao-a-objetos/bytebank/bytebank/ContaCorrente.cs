using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        private string _numeroDaConta;
        private int _numeroDaAgencia;
        private double _saldoDaConta;

        public ContaCorrente(string numeroDaConta, int numeroDaAgencia, string nomeDaAgencia, double saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NumeroDaAgencia = numeroDaAgencia;
            NomeDaAgencia = nomeDaAgencia;
            SaldoDaConta = saldoDaConta;
            TotalDeContas++;
        }

        public Cliente Titular { get; set; }
        public string NomeDaAgencia { get; set; }
        public string NumeroDaConta
        {
            get => _numeroDaConta;
            set
            {
                if (value != null)
                {
                    _numeroDaConta = value;
                }
            }
        }
        public int NumeroDaAgencia
        {
            get => _numeroDaAgencia;
            set
            {
                if (value > 0)
                {
                    _numeroDaAgencia = value;
                }
            }
        }
        public double SaldoDaConta
        {
            get
            {
                return _saldoDaConta;
            }
            set
            {
                if (value > 0)
                {
                    _saldoDaConta = value;
                }
            }
        }
        public static int TotalDeContas { get; set; }

        public bool Sacar(double valorDeSaque)
        {
            if ((SaldoDaConta < valorDeSaque) || (valorDeSaque <= 0))
            {
                return false;
            }
            else
            {
                SaldoDaConta -= valorDeSaque;
                return true;
            }
        }
        public void Depositar(double valorDeDeposito)
        {
            if (valorDeDeposito >= 0)
            {
                SaldoDaConta += valorDeDeposito;
            }
        }
        public bool Transferir(double valorDeTransferencia, ContaCorrente contaDestino)
        {
            if ((SaldoDaConta < valorDeTransferencia) || (valorDeTransferencia <= 0))
            {
                return false;
            }
            else
            {
                SaldoDaConta -= valorDeTransferencia;
                contaDestino.SaldoDaConta += valorDeTransferencia;
                return true;
            }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular.nomeDoCliente}");
            Console.WriteLine($"Conta: {NumeroDaConta}");
            Console.WriteLine($"Número da Agência: {NumeroDaAgencia}");
            Console.WriteLine($"Nome da Agência: {NomeDaAgencia}");
        }
    }
}
