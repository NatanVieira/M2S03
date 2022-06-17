using GeraEstoque.Models;
namespace GeraEstoque.Repositories;

public class ProdutoRepository {
    public IList<Produto> produtos;

    ProdutoRepository() {
        produtos = new List<Produto>();
    }
}