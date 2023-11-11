



Console.Write("Digite a quantidade de números: ");
int x = int.Parse(Console.ReadLine());
int soma = 0;

for (int y = 0; y < x; y++)
{
    Console.Write("Digite um número: ");
    int z = int.Parse(Console.ReadLine());
    soma += z;
}

Console.WriteLine($"A soma dos números é igual a {soma}");