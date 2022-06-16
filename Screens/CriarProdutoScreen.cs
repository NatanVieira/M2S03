namespace GeraEstoque.Screens;

public static class CriarProdutoScreen {
    
    public static void Iniciar() {
        string? nome = "";
        double? qtdEstoque = 0;
        decimal? valorCompra = 0M;
        decimal? valorVenda = 0M;
        
        Console.WriteLine("Preencha as informações abaixo");
        Console.WriteLine("Nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Quantidade em estoque:");
        qtdEstoque = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Valor de compra:");
        valorCompra = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Valor de venda:");
        valorVenda = Convert.ToDecimal(Console.ReadLine());
        string id = Guid.NewGuid().ToString();
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Qtd: {0}", qtdEstoque);
        Console.WriteLine($"R$ Compra: {valorCompra.ToString()}");
        Console.WriteLine($"R$ Venda: {valorVenda}");
        Console.WriteLine("Pressione Qualquer tecla para voltar ao menu");
        // string? voltaMenu = Console.ReadLine();
        // if (voltaMenu != null && voltaMenu != "")
        //     MenuScreen.Iniciar();
    }
}