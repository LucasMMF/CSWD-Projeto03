using Projeto03.Entities;
using Projeto03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Controllers
{
    public class ProdutoController
    {
        // Método para realizar o cadastro de um produto
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE PRODUTO:\n");

                var produto = new Produto();

                Console.Write("Entre com o nome do produto.........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Entre com o preço do produto........: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto...: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Create(produto);

                Console.WriteLine("\nProduto cadastrado com sucesso!");

            }
            catch(Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar produto: {e.Message}");
            }
        }
    }
}
