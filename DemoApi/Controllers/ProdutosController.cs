using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;

    public ProdutosController(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var valor1 = _configuration["chave"];

        List<Produto> produtos = _context.Produtos.ToList();

        if (produtos is null)
        {
            return NotFound();
        }

        return produtos;
    }

    [HttpGet("{id:int}", Name = "ObterProduto")]
    public ActionResult<Produto> Get(int id)
    {
        Produto? produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

        if (produto is null)
        {
            return NotFound();
        }

        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        // validações são feitas automaticamente

        // incluir os dados no contexto e persistir na tabela
        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
    }

    //TODO: estudar verbo HttpPatch
    [HttpPut]
    public ActionResult Put(int id, Produto produto)
    {
        if (id != produto.ProdutoId)
        {
            return BadRequest();
        }

        var produtoBusca = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);


        if (produtoBusca is null)
        {
            return NotFound();
        }

        _context.Entry(produto).State = EntityState.Modified;

        return Ok(produto);
    }

    [HttpDelete]
    public ActionResult Delete(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
        // var produto = _context.Produtos.Find(id);

        if (produto is null)
        {
            return NotFound("produto não localizado");
        }

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return Ok(produto);
    }
}