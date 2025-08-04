
public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public Produto Create(Produto produto)
    {
        if (produto is null)
            throw new ArgumentNullException(nameof(produto));

        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return produto;
    }

    public bool Delete(int id)
    {
        var produto = _context.Produtos.Find(id);

        if (produto is not null)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public Produto GetProduto(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

        if (produto is null)
            throw new ArgumentNullException();

        return produto;
    }

    public IEnumerable<Produto> GetProdutos()
    {
        var produtos = _context.Produtos.ToList();

        return produtos;
    }

    public bool Update(Produto produto)
    {
        if (produto is null)
            throw new ArgumentNullException(nameof(produto));

        if (_context.Produtos.Any(p => p.ProdutoId == produto.ProdutoId))
        {
            // _context.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return true;
        }

        return false;
    }
}