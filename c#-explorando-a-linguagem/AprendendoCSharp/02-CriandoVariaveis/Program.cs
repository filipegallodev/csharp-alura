Console.WriteLine("Projeto 02 - Criando Variáveis\n");

// Variáveis numéricas
int idade = 22;
int diasDoMes = 30;
double salarioMensal = 3295.50; // double, numero quebrado de até 2 casas após a vírgula
double salarioPorDia = salarioMensal / diasDoMes;

// short intCurto = 15000;  short, 16 bits

// int intComum = 1500000000;  comum/medio, 32 bits

// long intLongo = 1500000000000000000;  long, 64 bits

float piNum = 3.14159265359f; // float, mais preciso que o double

Console.WriteLine("Filipe tem " + idade + " anos de idade. " +
    "O salário dele é de R$" + salarioMensal + "/mês. O que dá R$" + salarioPorDia + "/dia.");
Console.WriteLine("O PI é: " + piNum);
// Fim das variáveis numéricas

// Variáveis de texto
string nome = "Filipe Gallo";
string cargo = "Estagiário de TI";
char letra = 'b';

Console.WriteLine(nome + " é um " + cargo);
Console.WriteLine("Letra " + letra);

letra = Convert.ToChar(65); // Letra A na tabela ASCII

Console.WriteLine(letra);

string cursos = @"Cursos disponíveis: 
      - Go 
    - C# 
        - Python 
  - Java"; // Se utilizar um @ antes da string, o texto quando for impresso, sairá exatamente como está definido

Console.WriteLine(cursos);
