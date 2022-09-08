using bytebank_ADM.Funcionarios;

Console.WriteLine("Bem-vindo ao ByteBank Administração!\n");

Funcionario funcionario1 = new("Filipe Gallo", "2938128320", 1908.0);

Console.WriteLine($"Bonificação: R$ {funcionario1.Bonificacao}");
