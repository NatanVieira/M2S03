using GeraEstoque.Models;
namespace GeraEstoque.Repositories;

public class ProdutoRepository {
    public IList<Produto> produtos;

    public ProdutoRepository() {
        produtos = new List<Produto>();
    }
}