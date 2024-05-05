using Dapper;
using Projeto03.Configurations;
using Projeto03.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Repositories
{
    public class ProdutoRepository
    {
        public void Create(Produto produto)
        {
            // Escrevendo um comando SQL para gravar um produto na tabela
            var query = @"
                INSERT INTO PRODUTO(
                    IDPRODUTO,
                    NOME,
                    PRECO,
                    QUANTIDADE,
                    DATACADASTRO)
                VALUES(
                    NEWID(),
                    @Nome,
                    @Preco,
                    @Quantidade,
                    GETDATE())
            ";

            // Conectando no banco de dados
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                // Executando o comando SQL no banco
                // passando os dados do objeto
                connection.Execute(query, produto);
            }
        }

        public void Update(Produto produto)
        {
            // TODO
        }

        public void Delete(Produto produto) 
        {
            // TODO
        }

        public List<Produto> GetAll()
        {
            // TODO
            return null;
        }

        public Produto GetById(Guid idProduto)
        {
            // TODO
            return null;
        }
    }
}
