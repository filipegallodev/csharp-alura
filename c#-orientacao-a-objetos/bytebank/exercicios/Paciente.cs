using exercicios;

Console.WriteLine("Bem vindo! Treinando com exercícios por aqui!");

Produto produto1 = new Produto();

produto1.nomeDoProduto = "Toddy";
produto1.fabricanteDoProduto = "PepsiCo";
produto1.codigoDeBarras = "12398123819239405";
produto1.valorUnitario = 5.0;
produto1.valorDeCompra = 7.5;
produto1.quantidadeNoEstoque = 195;

Console.WriteLine("[--- Produto ---]");
Console.WriteLine($"Nome: {produto1.nomeDoProduto}");
Console.WriteLine($"Preço: R${produto1.valorDeCompra}");
Console.WriteLine($"Quantidade em Estoque: {produto1.quantidadeNoEstoque}");

ContaCorrenteEx conta1 = new ContaCorrenteEx();

Console.WriteLine($"Valor padrão da string: {conta1.nomeDoTitular}");
Console.WriteLine($"Valor padrão do int: {conta1.numeroDaAgencia}");
Console.WriteLine($"Valor padrão do double: {conta1.saldoDaConta}");
Console.WriteLine($"Valor padrão do bool: {conta1.verificador}");

Paciente paciente1 = new Paciente();

Console.WriteLine($"Nome: {paciente1.nome}");
Console.WriteLine($"Idade: {paciente1.idade}");
Console.WriteLine($"Altura: {paciente1.altura}");
Console.WriteLine($"Peso: {paciente1.peso}");