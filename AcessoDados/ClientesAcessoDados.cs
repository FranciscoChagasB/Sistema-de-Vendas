using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace AcessoDados
{
    public class ClientesAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar um cliente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Clientes (NOME_CLIENTE, ENDERECO_CLIENTE, BAIRRO_CLIENTE, CEP_CLIENTE,");
                    sql.Append(" CIDADE_CLIENTE, ESTADO_CLIENTE, TELEFONE_CLIENTE, EMAIL_CLIENTE,");
                    sql.Append(" DATA_CADASTRO_CLIENTE, NASCIMENTO_CLIENTE, OBSERVACOES_CLIENTE, STATUS_CLIENTE)");
                    sql.Append("VALUES (@nome, @endereco, @bairro, @cep, @cidade, @estado, @telefone,");
                    sql.Append(" @email, @dataCadastro, @nascimento, @observacao, @status)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", estado));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacoes));
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

        public void SalvarPessoaFisica(int idCliente, string cpf, string rg) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar uma pessoa física no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Pessoa_fisica (ID_CLIENTE, CPF_CLIENTE, RG_CLIENTE)");
                    sql.Append(" VALUES (@idCliente, @cpf, @rg)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar uma pessoa jurídica no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Pessoa_juridica (ID_CLIENTE, CNPJ_CLIENTE, IE_CLIENTE)");
                    sql.Append(" VALUES (@idCliente, @cnpj, @ie)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                    comandoSql.Parameters.Add(new SqlParameter("@ie", ie));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Listar()
        //Método com o comando sql para listar os clientes existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarPessoaFisica(int idCliente) //parâmetros que serão inseridos.
        //Método com o comando sql para listar as pessoas físicas existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT CPF_CLIENTE, RG_CLIENTE FROM Pessoa_fisica");
                    sql.Append(" WHERE ID_CLIENTE = @idCliente");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarPessoaJuridica(int idCliente) //parâmetros que serão inseridos.
        //Método com o comando sql para listar as pessoas jurídicas existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT CNPJ_CLIENTE, IE_CLIENTE FROM Pessoa_juridica");
                    sql.Append(" WHERE ID_CLIENTE = @idCliente");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                          string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar algum cliente existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Clientes");
                    sql.Append(" SET NOME_CLIENTE=@nome, ENDERECO_CLIENTE=@endereco, BAIRRO_CLIENTE=@bairro, CEP_CLIENTE=@cep, CIDADE_CLIENTE=@cidade, ");
                    sql.Append(" ESTADO_CLIENTE=@estado, TELEFONE_CLIENTE=@telefone, EMAIL_CLIENTE=@email, DATA_CADASTRO_CLIENTE=@dataCadastro, ");
                    sql.Append(" NASCIMENTO_CLIENTE=@nascimento, OBSERVACOES_CLIENTE=@observacao, STATUS_CLIENTE=@status");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@estado", estado));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacoes));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));

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

        public void AlterarPessoaFisica(int idCliente, string cpf, string rg) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar alguma pessoa física existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Pessoa_fisica");
                    sql.Append(" SET ID_CLIENTE=@idCliente, CPF_CLIENTE=@cpf, RG_CLIENTE=@rg");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar alguma pessoa jurídica existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Pessoa_juridica");
                    sql.Append(" SET ID_CLIENTE=@idCliente, CNPJ_CLIENTE=@cnpj, IE_CLIENTE=@ie)");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                    comandoSql.Parameters.Add(new SqlParameter("@ie", ie));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Excluir(int idCliente) //parâmetros que serão inseridos.
        //Método com o comando sql para excluir algum cliente existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE from Clientes");
                    sql.Append(" WHERE (ID_CLIENTE = @idCliente)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("idCliente", idCliente));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaNome(string nome, string ordem) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar os dados dos clientes que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%'");
                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_CLIENTE");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_CLIENTE");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_CLIENTE");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_CLIENTE");
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
                throw new Exception("Ocorreu um erro no método PesquisaNome. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaCpf(string nome, string ordem)
        //Método com o comando sql que irá selecionar e retornar os dados dos clientes CADASTRADOS COM CPF que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Clientes.*, Pessoa_fisica.*  FROM Clientes INNER JOIN Pessoa_fisica");
                    sql.Append(" ON Clientes.ID_CLIENTE = Pessoa_fisica.ID_CLIENTE");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%'");
                    
                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_CLIENTE");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_CLIENTE");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_CLIENTE");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_CLIENTE");
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
                throw new Exception("Ocorreu um erro no método PesquisaCPF. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaCnpj(string nome, string ordem)
        //Método com o comando sql que irá selecionar e retornar os dados dos clientes CADASTRADOS COM CNPJ que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Clientes.*, Pessoa_juridica.*  FROM Clientes INNER JOIN Pessoa_juridica");
                    sql.Append(" ON Clientes.ID_CLIENTE = Pessoa_juridica.ID_CLIENTE");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_CLIENTE");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_CLIENTE");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_CLIENTE");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_CLIENTE");
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
                throw new Exception("Ocorreu um erro no método PesquisaCnpj. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaAtivos(string nome, string ordem)
        //Método com o comando sql que irá selecionar e retornar os dados dos clientes ATIVOS que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%' AND STATUS_CLIENTE = 'Ativo'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_CLIENTE");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_CLIENTE");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_CLIENTE");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_CLIENTE");
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
                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%' AND STATUS_CLIENTE = 'Inativo'");

                    switch (ordem)
                    {
                        case "Código":
                            sql.Append(" ORDER BY ID_CLIENTE");
                            break;
                        case "Nome":
                            sql.Append(" ORDER BY NOME_CLIENTE");
                            break;
                        case "Situação":
                            sql.Append(" ORDER BY STATUS_CLIENTE");
                            break;
                        default:
                            sql.Append(" ORDER BY NOME_CLIENTE");
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
