

using PrimeiroProjeto;

Console.WriteLine("Entre com a altura e largura do retângulo:");

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Largura: ");
double largura = double.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(altura, largura);

Console.WriteLine(retangulo.retornaArea());
Console.WriteLine(retangulo.retornaPerimetro());
Console.WriteLine(retangulo.retornaDiagonal());