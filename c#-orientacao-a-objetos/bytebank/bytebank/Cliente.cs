namespace bytebank.Titular
{
    public class Cliente
    {
        public string nomeDoCliente { get; set; }
        public string cpfDoCliente { get; set; }
        public string profissaoDoCliente { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            nomeDoCliente = nome;
            cpfDoCliente = cpf;
            profissaoDoCliente = profissao;
            TotalDeClientes++;
        }

        public static int TotalDeClientes { get; set; }
    }
}
