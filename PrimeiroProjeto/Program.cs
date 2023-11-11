

using PrimeiroProjeto;

Produto produto = new Produto();

Console.Write("Digite o nome do produto: ");
produto.nome = Console.ReadLine();

Console.Write("Digite a quantidade do produto: ");
produto.quantidade = int.Parse(Console.ReadLine());

Console.Write("Digite o preço do produto: ");
produto.preco = double.Parse(Console.ReadLine());
Console.WriteLine();


Console.WriteLine($"Dados do Produto: {produto.valorTotalEmEstoque()} \n");

Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
produto.adicionarProduto(int.Parse(Console.ReadLine()));
Console.WriteLine();

Console.WriteLine($"Dados Atualizados: {produto.valorTotalEmEstoque()} \n");

Console.Write("Digite o número de produtos a ser removido do estoque: ");
produto.removerProduto(int.Parse(Console.ReadLine()));
Console.WriteLine();

Console.WriteLine($"Dados Atualizados: {produto.valorTotalEmEstoque()}");