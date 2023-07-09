using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class FuncionariosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, string cpf, string rg, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar um funcionário no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Funcionarios (NOME_FUNCIONARIO, RG_FUNCIONARIO, CPF_FUNCIONARIO, ENDERECO_FUNCIONARIO, ");
                    sql.Append("BAIRRO_FUNCIONARIO, ESTADO_FUNCIONARIO, CEP_FUNCIONARIO, CIDADE_FUNCIONARIO, TELEFONE_FUNCIONARIO, ");
                    sql.Append("EMAIL_FUNCIONARIO, NASCIMENTO_FUNCIONARIO, OBSERVACOES_FUNCIONARIO, ");
                    sql.Append("DATA_CADASTRO_FUNCIONARIO, STATUS_FUNCIONARIO)");

                    sql.Append("VALUES (@nome, @rg, @cpf, @endereco, @bairro, @estado, @cep, @cidade, @telefone,");
                    sql.Append("@email, @nascimento, @observacoes, @dataCadastro, @status)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", estado));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@observacoes", observacoes));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Listar()
        //Método com o comando sql para listar os funcionários existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Funcionarios");
                    sql.Append(" ORDER BY ID_FUNCIONARIO DESC");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public void Alterar(int idFuncionario, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string rg, string cpf, string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar algum funcionário existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Funcionarios");
                    sql.Append(" SET NOME_FUNCIONARIO=@nome, ENDERECO_FUNCIONARIO=@endereco, BAIRRO_FUNCIONARIO=@bairro, ");
                    sql.Append("CEP_FUNCIONARIO=@cep, CIDADE_FUNCIONARIO=@cidade, ESTADO_FUNCIONARIO=@estado , EMAIL_FUNCIONARIO=@email, ");
                    sql.Append("NASCIMENTO_FUNCIONARIO=@nascimento, OBSERVACOES_FUNCIONARIO=@observacoes, ");
                    sql.Append("TELEFONE_FUNCIONARIO=@telefone, RG_FUNCIONARIO=@rg, CPF_FUNCIONARIO=@cpf, ");
                    sql.Append("DATA_CADASTRO_FUNCIONARIO=@dataCadastro, STATUS_FUNCIONARIO=@status");

                    sql.Append(" WHERE (ID_FUNCIONARIO=@idFuncionario)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", estado));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@observacoes", observacoes));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Excluir(int idFuncionario) //parâmetros que serão inseridos.
        //Método com o comando sql para excluir algum cliente existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Funcionarios");
                    sql.Append(" WHERE (ID_FUNCIONARIO = @idFuncionario)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public DataTable PesquisarNome(string nome,  string ordem) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar os dados dos funcionários que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Funcionarios");
                    sql.Append(" WHERE NOME_FUNCIONARIO LIKE '%'+@nome+'%'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_FUNCIONARIO");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_FUNCIONARIO");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                    }

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarNome. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        public DataTable PesquisaAtivos(string nome, string ordem)
        //Método com o comando sql que irá selecionar e retornar os dados dos funcionários ATIVOS que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Funcionarios");
                    sql.Append(" WHERE NOME_FUNCIONARIO LIKE '%'+@nome+'%' AND STATUS_FUNCIONARIO = 'Ativo'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_FUNCIONARIO");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_FUNCIONARIO");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                    }

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaAtivos. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaInativos(string nome, string ordem)
        //Método com o comando sql que irá selecionar e retornar os dados dos clientes INATIVOS que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Funcionarios");
                    sql.Append(" WHERE NOME_FUNCIONARIO LIKE '%'+@nome+'%' AND STATUS_FUNCIONARIO = 'Inativo'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_FUNCIONARIO");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_FUNCIONARIO");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_FUNCIONARIO");
                            break;
                    }

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaInativos. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
