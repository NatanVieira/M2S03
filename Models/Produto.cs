namespace GeraEstoque.Models;

public class Produto {

        public string? nome { get; set; }
        public double qtdEstoque { get; set; }
        public decimal? valorCompra { get; set; }
        public decimal? valorVenda { get; set; }
        public Guid id { get; set; }

        public Produto(){

        }
        public Produto(string nome, double qtdEstoque, decimal valorCompra, decimal valorVenda){
            this.nome = nome;
            this.qtdEstqoque = qtdEstoque;
            this.valorCompra = valorCompra;
            this.valorVenda = valorVenda;
            this.id = Guid.NewGuid();
        }

    public override string ToString()
    {
        return $"Produto: ID: {this.id} | Nome: {this.nome} | Qtd: {this.qtdEstqoque} | R$ Compra: {this.valorCompra} | R$ Venda: {this.valorVenda}";
    }
}