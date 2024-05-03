namespace ControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(40, "Sakura_tree", 0, 20000);
            p.imprimir();
            p.entrada(40);
            p.imprimir();
            p.venda(7);
            p.imprimir();
        }
    }
}
