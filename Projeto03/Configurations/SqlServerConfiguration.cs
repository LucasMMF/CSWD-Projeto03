using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Configurations
{
    public class SqlServerConfiguration
    {
        /// <summary>
        /// Método para retornar o endereço
        /// da ConnectionString do banco de dados
        /// </summary>
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProjeto03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
