using GeraEstoque.Repositories;
using GeraEstoque.Models;
namespace GeraEstoque.Screens;

public static class CriarProdutoScreen {
    
    public static void Iniciar(ProdutoRepository repositorio) {        
        Console.WriteLine("Preencha as informações abaixo");
        Produto produto = new Produto();
        Console.WriteLine("Nome:");
        produto.nome = Console.ReadLine();
        Console.WriteLine("Quantidade em estoque:");
        produto.qtdEstoque= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Valor de compra:");
        produto.valorCompra = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Valor de venda:");
        produto.valorVenda = Convert.ToDecimal(Console.ReadLine());
        repositorio.produtos.Add(produto);
        // Console.WriteLine("ID: {0}", id);
        // Console.WriteLine("Nome: {0}", nome);
        // Console.WriteLine("Qtd: {0}", qtdEstoque);
        // Console.WriteLine($"R$ Compra: {valorCompra.ToString()}");
        // Console.WriteLine($"R$ Venda: {valorVenda}");
        // Console.WriteLine("Pressione Qualquer tecla para voltar ao menu");
        // string? voltaMenu = Console.ReadLine();
        // if (voltaMenu != null && voltaMenu != "")
        //     MenuScreen.Iniciar();
    }
}