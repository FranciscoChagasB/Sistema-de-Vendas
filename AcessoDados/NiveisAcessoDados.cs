using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class NiveisAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, string descricao)
        //Método com o comando sql para salvar um nivel de usuário no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Nivel_Usuarios (NOME_NIVEL, DESCRICAO_NIVEL)");
                    sql.Append(" VALUES (@nome, @descricao)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idNivel, string nome, string descricao)
        //Método com o comando sql para alterar algum nível existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Nivel_Usuarios");
                    sql.Append(" SET NOME_NIVEL = @nome, DESCRICAO_NIVEL = @descricao");
                    sql.Append(" WHERE (ID_NIVEL = @idNivel)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Excluir(int idNivel)
        //Método com o comando sql para excluir algum nível existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Nivel_Usuarios");
                    sql.Append(" WHERE (ID_NIVEL = @idNivel)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Listar()
        //Método com o comando sql para listar os níveis existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Nivel_Usuarios");
                    sql.Append(" ORDER BY ID_NIVEL ASC");

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
