Console.WriteLine("Projeto 05 - Laços de Repetição");

double investimento = 1000;
int mes = 1;

Console.WriteLine("Utilizando a repetição while:");
while (mes <= 12)
{
    investimento = investimento + (investimento * 0.005);
    Console.WriteLine("Mês " + mes + ": R$" + investimento);
    mes++;
}

investimento = 1000;

Console.WriteLine("\nUtilizando a repetição for:");
for (int i = 1; i <=12; i++)
{
    investimento *= 1.005; // simplificando a conta anterior
    Console.WriteLine("Mês " + i + ": R$" + investimento);
}
