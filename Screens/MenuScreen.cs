using System;
using System.Globalization;
namespace GeraEstoque.Screens;

public static class MenuScreen {

    public static void Iniciar() {
                Console.Clear();
                System.Console.WriteLine("Seja Bem Vindo ao GeraEstoque 1.0");
                System.Console.WriteLine("------------------------------------------");

                System.Console.WriteLine("1 - Cadastrar Produto");
                System.Console.WriteLine("2 - Consultar Produto");
                System.Console.WriteLine("3 - Modificar Produto");
                System.Console.WriteLine("4 - Excluir Produto");
                System.Console.WriteLine("0 - Sair");

                System.Console.WriteLine("Digite a opção:");
                string? escolhaUsuario = Console.ReadLine();

                switch (escolhaUsuario)
                {
                    case "1":
                        CriarProdutoScreen.Iniciar();
                        Iniciar();
                        break;
                    case "2":
                        Iniciar();
                        break;
                    case "3":
                        Iniciar();
                        break;
                    case "4":
                        Iniciar();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada");
                        Iniciar();
                        break;
                }
    }
}