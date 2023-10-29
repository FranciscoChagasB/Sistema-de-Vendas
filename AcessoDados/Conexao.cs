using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    class Conexao
    {
        //Variável que armazena a String de Conexão.
        private static string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Vendas_FranciscodasChagas;Integrated Security=True";

        //Método para acessar a String de Conexão.
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
