using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class BancoSqlAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public DataTable VerificarBanco()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; database=master; Integrated Security=SSPI"))
                {
                    conexao.Open();
                    sql.Append("SELECT * FROM sys.databases where name = 'Vendas_FranciscodasChagas'");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método VerificarBanco. Caso o problema persista, entre em contado com o Administrador do Sistema.");
            }
        }

        public void CriarBanco(string ScriptBancoConstrucao, string ScriptTabelasConstrucao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; Integrated Security = SSPI"))
                {
                    conexao.Open();

                    sql.Append(ScriptBancoConstrucao);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();

                    sql.Clear();

                    sql.Append(ScriptTabelasConstrucao);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método CriarBanco. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void CriarUsuario()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Usuarios VALUES ('Administrador', '10-10-2013', 'Admin', 'e3afed0047b08059d0fada10f400c1e5', 'ATIVO', '1')");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método CriarUsuario. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void CriarNiveis()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Nivel_Usuarios VALUES ('Administrador', 'Tem controle total no sistema.')");
                    sql.Append("INSERT INTO Nivel_Usuarios VALUES ('Gerente', 'Só não consegue cadastrar novos usuários. Responsável pelos relatórios, abertura e fechamento de caixa.')");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método CriarNiveis. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
