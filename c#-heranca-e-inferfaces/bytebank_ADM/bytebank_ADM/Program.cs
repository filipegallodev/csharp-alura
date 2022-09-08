using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Bem-vindo ao ByteBank Administração!\n");

Bonificacao bonificacao = new();
Funcionario funcionario1 = new("Filipe Gallo", "2938128320", 2000.0);
Diretor diretor1 = new("João de Almeida", "2738127819", 5000.0);

bonificacao.Registrar(funcionario1);
bonificacao.Registrar(diretor1);

Console.WriteLine($"Bonificação: R$ {bonificacao.TotalBonificacao}");
