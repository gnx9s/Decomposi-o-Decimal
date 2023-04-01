Console.WriteLine("Escreva um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

int resto = numero;

int unidades = resto % 10;
resto /= 10;

int dezenas = resto % 10;
resto /= 10;

int unidade_de_milhar = resto;

int centenas = unidade_de_milhar % 10;
unidade_de_milhar /= 10;

Console.WriteLine($"{unidades,10} unidade(s):");
Console.WriteLine($"{dezenas,10} dezena(s):");
Console.WriteLine($"{centenas,10} centena(s)");
Console.WriteLine($"{unidade_de_milhar,10} unidade de milhar(es)");
