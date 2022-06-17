using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;

public static class ListarProdutoScreen {
    
    public static void Iniciar (ProdutoRepository repositorio){
        System.Console.WriteLine("LISTA DE PRODUTOS CADASTRADOS");
        System.Console.WriteLine("---------------------------------------------------");
        for(int i = 0; i < repositorio.produtos.Count; i++){
            System.Console.WriteLine(repositorio.produtos[i].ToString());
        }
        Console.ReadLine();
    }
}