public interface IProdutoRepository
{
    public IEnumerable<Produto> GetProdutos();
    public Produto GetProduto(int id);
    public Produto Create(Produto produto);
    public bool Delete(int id);
    public bool Update(Produto produto);
}