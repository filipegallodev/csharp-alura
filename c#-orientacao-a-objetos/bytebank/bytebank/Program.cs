using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, o ByteBank!");

ContaCorrente conta1 = new ContaCorrente("10123-X", 23, "Agência Central", 153.95);
conta1.Titular = new Cliente("Filipe Gallo", "2938277184", "Desenvolvedor .NET");

ContaCorrente conta2 = new ContaCorrente("10238-X", 54, "Agência Cillos", 165);
conta2.Titular = new Cliente("José Mariano Gomes", "5831729543", "Marceneiro");

conta1.ExibirInformacoes();

bool statusSaque = conta1.Sacar(50);

Console.WriteLine($"Saque realizado? {statusSaque}");
Console.WriteLine($"Saldo depois do saque: R$ {conta1.SaldoDaConta:0.00}");

conta1.Depositar(100);

Console.WriteLine($"Saldo depois do depósito: R$ {conta1.SaldoDaConta:0.00}");

Console.WriteLine($"Saldo do {conta1.Titular.nomeDoCliente} antes da transferência: R$ {conta1.SaldoDaConta:0.00}");
Console.WriteLine($"Saldo do {conta2.Titular.nomeDoCliente} antes da transferência: R$ {conta2.SaldoDaConta:0.00}");

bool statusTransferencia = conta1.Transferir(25, conta2);

Console.WriteLine($"Transferência realizada? {statusTransferencia}");
Console.WriteLine($"Saldo do {conta1.Titular.nomeDoCliente} depois da transferência: R$ {conta1.SaldoDaConta:0.00}");
Console.WriteLine($"Saldo do {conta2.Titular.nomeDoCliente} depois da transferência: R$ {conta2.SaldoDaConta:0.00}");

Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalDeContas}");
Console.WriteLine($"Total de clientes do banco: {Cliente.TotalDeClientes}");

Console.ReadKey();
