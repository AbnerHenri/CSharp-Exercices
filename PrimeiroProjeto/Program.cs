

using System.Globalization;

Console.Write("Entre com o seu nome: ");
string name = Console.ReadLine();

Console.Write("Quantos quartos tem na sua casa: ");
int quartos = int.Parse(Console.ReadLine());

Console.Write("Entre com o preço do produto: ");
string preco = Console.ReadLine();

Console.Write("Entre com seu último nome, idade, altura (mesma linha): ");
string[] data = Console.ReadLine().Split(' ');

Console.WriteLine($"Nome: {name}");
Console.WriteLine($"Quantidade de Quartos: {quartos}");
Console.WriteLine($"Preço dado : {Double.Parse(preco, CultureInfo.CurrentCulture)}");

Console.WriteLine($"Último nome: {data[0]}");
Console.WriteLine($"Idade: {data[1]}");
Console.WriteLine($"Altura: {data[2]}cm");