
namespace PrimeiroProjeto
{
    internal class Produto
    {
        public string nome { get; set; }
        public int quantidade { get; set;}
        public double preco { get; set; }

        public string valorTotalEmEstoque()
        {
            return $"TV, R${preco}, R${quantidade} Unidades, Total: {preco * quantidade}"; ;
        }

        public void adicionarProduto(int amount)
        {
            quantidade += amount;
        }

        public void removerProduto(int amount)
        {
            quantidade -= amount;
        }
    }
}
