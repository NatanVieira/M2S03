// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");;
using GeraEstoque.Screens;
using GeraEstoque.Repositories;
namespace GeraEstoque {

    class Program {
        static void Main(string[] args)
        {
           ProdutoRepository repositorio = new ProdutoRepository();

           MenuScreen.Iniciar(repositorio); 
        }
    }
}
