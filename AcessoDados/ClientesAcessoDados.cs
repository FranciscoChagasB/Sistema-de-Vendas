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
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Clientes (NOME_CLIENTE, ENDERECO_CLIENTE, BAIRRO_CLIENTE, CEP_CLIENTE,");
                    sql.Append(" CIDADE_CLIENTE, ESTADO_CLIENTE, TELEFONE_CLIENTE, EMAIL_CLIENTE,");
                    sql.Append(" DATA_CADASTRO_CLIENTE, NASCIMENTO_CLIENTE, OBSERVACOES_CLIENTE, STATUS_CLIENTE)");
                    sql.Append("VALUES (@nome, @endereco, @bairro, @cep, @cidade, @estado, @telefone,");
                    sql.Append(" @email, @dataCadastro, @nascimento, @observacao, @status)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
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

                    comandoSql.CommandText = sql.ToString(); //converter texto para script sql server.
                    comandoSql.Connection = conexao; //iniciar a conexao com o banco.
                    comandoSql.ExecuteNonQuery(); //executar o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarPessoaFisica(int idCliente, string cpf, string rg) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Pessoa_fisica (ID_CLIENTE, CPF_CLIENTE, RG_CLIENTE)");
                    sql.Append(" VALUES (@idCliente, @cpf, @rg)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Pessoa_juridica (ID_CLIENTE, CNPJ_CLIENTE, IE_CLIENTE)");
                    sql.Append(" VALUES (@idCliente, @cnpj, @ie)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                    comandoSql.Parameters.Add(new SqlParameter("@ie", ie));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

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

        public DataTable ListarPessoaFisica(int idCliente) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT CPF_CLIENTE, RG_CLIENTE FROM Pessoa_fisica");
                    sql.Append(" WHERE ID_CLIENTE = @idCliente");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarPessoaJuridica(int idCliente) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();


                    sql.Append("SELECT CNPJ_CLIENTE, IE_CLIENTE FROM Pessoa_juridica");
                    sql.Append(" WHERE ID_CLIENTE = @idCliente");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                          string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Clientes");
                    sql.Append(" SET NOME_CLIENTE=@nome, ENDERECO_CLIENTE=@endereco, BAIRRO_CLIENTE=@bairro, CEP_CLIENTE=@cep, CIDADE_CLIENTE=@cidade, ");
                    sql.Append(" ESTADO_CLIENTE=@estado, TELEFONE_CLIENTE=@telefone, EMAIL_CLIENTE=@email, DATA_CADASTRO_CLIENTE=@dataCadastro, ");
                    sql.Append(" NASCIMENTO_CLIENTE=@nascimento, OBSERVACOES_CLIENTE=@observacao, STATUS_CLIENTE=@status");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
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

        public void AlterarPessoaFisica(int idCliente, string cpf, string rg) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Pessoa_fisica");
                    sql.Append(" SET ID_CLIENTE=@idCliente, CPF_CLIENTE=@cpf, RG_CLIENTE=@rg");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarPessoaFisica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Pessoa_juridica");
                    sql.Append(" SET ID_CLIENTE=@idCliente, CNPJ_CLIENTE=@cnpj, IE_CLIENTE=@ie)");
                    sql.Append(" WHERE (ID_CLIENTE=@idCliente)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                    comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                    comandoSql.Parameters.Add(new SqlParameter("@ie", ie));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Excluir(int idCliente) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE from Clientes");
                    sql.Append(" WHERE (ID_CLIENTE = @idCliente)");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("idCliente", idCliente));

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

        public DataTable PesquisaNome(string nome) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE NOME_CLIENTE LIKE '%'+@nome+'%'");
                    sql.Append(" ORDER BY NOME_CLIENTE ASC");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaNome. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaCpf(string cpf) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Clientes.*, Pessoa_fisica.*  FROM Cliente INNER JOIN Pessoa_fisica");
                    sql.Append(" ON Cliente.ID_CLIENTE = Pessoa_fisica.ID_CLIENTE");
                    sql.Append(" WHERE CPF_CLIENTE LIKE '%'+@cpf+'%'");
                    sql.Append(" ORDER BY NOME_CLIENTE ASC");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaCpf. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaCnpj(string cnpj) //parâmetros que serão inseridos.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Clientes.*, Pessoa_juridica.*  FROM Cliente INNER JOIN Pessoa_juridica");
                    sql.Append(" ON Cliente.ID_CLIENTE = Pessoa_juridica.ID_CLIENTE");
                    sql.Append(" WHERE CNPJ_CLIENTE LIKE '%'+@cnpj+'%'");
                    sql.Append(" ORDER BY NOME_CLIENTE ASC");

                    //configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaCnpj. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
