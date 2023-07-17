﻿
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ProdutoAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void SalvarCategoria(string nomeCategoria, string descricaoCategoria) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar uma categoria no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Categoria (NOME_CATEGORIA_PRODUTOS, DESCRICAO_CATEGORIA_PRODUTOS)");
                    sql.Append(" VALUES (@nomeCategoria, @descricaoCategoria)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nomeCategoria", nomeCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoCategoria", descricaoCategoria));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarCategoria(int idCategoria, string nomeCategoria, string descricaoCategoria) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar alguma categoria existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Categoria");
                    sql.Append(" SET NOME_CATEGORIA_PRODUTOS=@nomeCategoria, DESCRICAO_CATEGORIA_PRODUTOS=@descricaoCategoria");
                    sql.Append(" WHERE (ID_CATEGORIA_PRODUTOS = @idCategoria)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nomeCategoria", nomeCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoCategoria", descricaoCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirCategoria(int idCategoria) //parâmetros que serão inseridos.
        //Método com o comando sql para excluir alguma categoria existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Categoria");
                    sql.Append(" WHERE (ID_CATEGORIA_PRODUTOS = @idCategoria)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirCategoria. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarCategorias()
        //Método com o comando sql para listar as categorias existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Categoria");
                    sql.Append(" ORDER BY ID_CATEGORIA_PRODUTOS");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarCategorias. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void SalvarUnidade(string nomeUnidade, string descricaoUnidade) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar uma unidade no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Unidade (NOME_UNIDADE_PRODUTOS, DESCRICAO_UNIDADE_PRODUTOS)");
                    sql.Append(" VALUES (@nomeUnidade, @descricaoUnidade)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nomeUnidade", nomeUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoUnidade", descricaoUnidade));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarUnidade(int idUnidade, string nomeUnidade, string descricaoUnidade) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar alguma unidade existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Unidade");
                    sql.Append(" SET NOME_UNIDADE_PRODUTOS=@nomeUnidade, DESCRICAO_UNIDADE_PRODUTOS=@descricaoUnidade");
                    sql.Append(" WHERE (ID_UNIDADE_PRODUTOS = @idUnidade)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nomeUnidade", nomeUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@descricaoUnidade", descricaoUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirUnidade(int idUnidade) //parâmetros que serão inseridos.
        //Método com o comando sql para excluir alguma unidade existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Unidade");
                    sql.Append(" WHERE (ID_UNIDADE_PRODUTOS = @idUnidade)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ExcluirUnidade. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarUnidades()
        //Método com o comando sql para listar as unidades existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Unidade_produtos");
                    sql.Append(" ORDER BY ID_UNIDADE_PRODUTOS");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarUnidades. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }
    }
}
