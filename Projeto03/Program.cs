using Projeto03.Controllers;

namespace Projeto03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciando o controlador
            var produtoController = new ProdutoController();
            produtoController.CadastrarProduto();
        }
    }
}