using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class UsuariosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, DateTime data, string login, int idNivel, string senha, string status)
        //Método com o comando sql para salvar um usuário no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Usuarios (NOME_USUARIO, DATA_CADASTRO, LOGIN_USUARIO, SENHA_USUARIO, STATUS_USUARIO, ID_NIVEL)");
                    sql.Append(" VALUES (@nome, @data, @login, @senha, @status, @idNivel)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

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

        public void Alterar(int idUsuario, string nome, DateTime data, string login, int idNivel, string senha, string status)
        //Método com o comando sql para alterar algum usuráio existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Usuarios");
                    sql.Append(" SET NOME_USUARIO = @nome, DATA_CADASTRO = @data, LOGIN_USUARIO = @login, SENHA_USUARIO = @senha, STATUS_USUARIO = @status, ID_NIVEL = @idNivel");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

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

        public void Excluir(int idUsuario)
        //Método com o comando sql para excluir algum usuário existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Usuarios");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

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
        //Método com o comando sql para listar os usuários existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Usuarios.*, NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Usuarios");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Usuarios.ID_NIVEL");
                    sql.Append(" ORDER BY NOME_USUARIO ASC");

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

        public DataTable Login(string login, string senha)
        //Método com o comando sql para selecionar e retornar o usuário que informamos o login e senha.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Usuarios");
                    sql.Append(" WHERE LOGIN_USUARIO = @login AND SENHA_USUARIO = @senha");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Login. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarLogin(string login)
        //Método com o comando sql para selecionar e retornar o usuário que informamos o login.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Usuarios");
                    sql.Append(" WHERE LOGIN_USUARIO = @login");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));

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

        public DataTable RetornarUsuario(int idUsuario)
        /*Método com o comando sql que realiza a junção das tabelas Nível_Usuario e Usuarios
         *para selecionar e retornar os dados do usuário que informamos o ID.
        */
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //inicia a conexao com o banco de dados.
                    conexao.Open();

                    //cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Usuarios.*, NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Usuarios");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Usuarios.ID_NIVEL");
                    sql.Append(" WHERE ID_USUARIO = @idUsuario");

                    //configura os parâmetros que serão os dados inseridos na camada RegraNegocio.
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                    //cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarUsuario. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
