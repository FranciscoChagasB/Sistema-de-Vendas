
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
                    sql.Append("SELECT * FROM Unidade");
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

        public void Salvar(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                           decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto) //parâmetros que serão inseridos.
        //Método com o comando sql para salvar um produto no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("INSERT INTO Produtos (CODIGOBARRAS_PRODUTO, NOME_PRODUTO, DESCRICAO_PRODUTO, ID_UNIDADE, ID_CATEGORIA, ESTOQUE_MINIMO, ESTOQUE_ATUAL,");
                    sql.Append(" VALOR_COMPRA, VALOR_VENDA, MARGEM, ANOTACOES_PRODUTO, SITUACAO_PRODUTO, DATA_CADASTRO_PRODUTO)");
                    sql.Append(" VALUES (@codigoBarras, @nome, @descricao, @idUnidade, @idCategoria, @estoqueMinimo, @estoqueAtual, @valorCompra, @valorVenda, @margem,");
                    sql.Append(" @anotacoesProdutos, @situacaoProdutos, @dataCadastroProduto)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margem", margem));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoesProdutos", anotacoesProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@situacaoProdutos", situacaoProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastroProduto", dataCadastroProduto));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o erro persista, entre em contato com o administrador do sistema.");
            }
        }

        public void Alterar(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                            decimal valorCompra, decimal valorVenda, decimal margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto) //parâmetros que serão inseridos.
        //Método com o comando sql para alterar algum produto existente no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Produtos");
                    sql.Append(" SET CODIGOBARRAS_PRODUTO=@codigoBarras, NOME_PRODUTO=@nome, DESCRICAO_PRODUTO=@descricao,");
                    sql.Append(" ID_UNIDADE=@idUnidade, ID_CATEGORIA=@idCategoria, ESTOQUE_MINIMO=@estoqueMinimo,");
                    sql.Append(" ESTOQUE_ATUAL=@estoqueAtual, VALOR_COMPRA=@valorCompra, VALOR_VENDA=@valorVenda, MARGEM=@margem,");
                    sql.Append(" ANOTACOES_PRODUTO=@anotacoesProdutos, SITUACAO_PRODUTO=@situacaoProdutos, DATA_CADASTRO_PRODUTO=@dataCadastroProduto");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margem", margem));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoesProdutos", anotacoesProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@situacaoProdutos", situacaoProdutos));
                    comandoSql.Parameters.Add(new SqlParameter("@dataCadastroProduto", dataCadastroProduto));
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o erro persista, entre em contato com o administrador do sistema.");
            }
        }

        public DataTable Listar()
        //Método com o comando sql para listar os produtos existentes no banco de dados.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGOBARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO, Produtos.ESTOQUE_ATUAL,");
                    sql.Append(" Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO, Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO");
                    sql.Append(" FROM (Produtos INNER JOIN Unidade ON Produtos.ID_UNIDADE = Unidade.ID_UNIDADE_PRODUTOS)");
                    sql.Append(" ORDER BY Produtos.NOME_PRODUTO ASC");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o erro persista, entre em contato com o administrador do sistema.");
            }
        }

        public void Excluir(int idProduto) //parâmetros que serão inseridos.
        //Método com o comando sql para excluir algum produto existente no banco de dados ordenando-os por id.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("DELETE FROM Produtos");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("idProduto", idProduto));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Exclur. Caso o erro persista, entre em contato com o administrador.");
            }
        }

        public DataTable ListarProdutos()
        //Método com o comando sql para listar os produtos existentes no banco de dados ordenando-os por nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Produtos");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarProdutos. Caso o erro persista, entre em contado com o administrador do sistema.");
            }
        }

        public DataTable PesquisaCodigoBarras(string codigoBarras) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar dados com joins de consulta dos produtos que informamos o código de barras.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGOBARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO, Produtos.ESTOQUE_ATUAL,");
                    sql.Append(" Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO, Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO");
                    sql.Append(" FROM (Produtos INNER JOIN Unidade ON Produtos.ID_UNIDADE = Unidade.ID_UNIDADE_PRODUTOS)");
                    sql.Append(" WHERE Produtos.CODIGOBARRAS_PRODUTO LIKE '%'+@codigoBarras+'%'");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisaCodigoBarras. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarProduto(string codBarras) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar todos dados dos produtos que informamos o código de barras.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT * FROM Produtos");
                    sql.Append(" WHERE CODIGOBARRAS_PRODUTO = @codBarras");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("codBarras", codBarras));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa o script.
                    return dadosTabela; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarProduto. Caso o erro persista, entre em contato com o administrador do sistema");
            }
        }

        public int RetornarEstoqueProduto(int idProduto) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar todos dados do estoque que informamos o id.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT ESTOQUE_ATUAL FROM Produtos");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    int estoqueProduto = (Int32)comandoSql.ExecuteScalar(); //Executa o script.
                    return estoqueProduto; //Retorna o DataTable com os dados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarEstoqueProduto. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AtualizarEstoque(int idProduto, int estoqueAtual) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e atualizar todos dados do estoque que informamos o id.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("UPDATE Produtos");
                    sql.Append(" SET ESTOQUE_ATUAL = @estoqueAtual");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    //Configuração dos parâmetros inseridos com parâmetros no script.
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));

                    //Cria o script com o os comandos inseridos no texto "sql.Append" e o executa.
                    comandoSql.CommandText = sql.ToString(); //Converter texto para script sql server.
                    comandoSql.Connection = conexao; //Iniciar a conexão com o banco.
                    comandoSql.ExecuteNonQuery(); //Executa o script.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AtualizarEstoque. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisaNome(string nome) //parâmetros que serão inseridos.
        //Método com o comando sql que irá selecionar e retornar todos dados dos produtos que informamos o nome.
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    //Inicia a conexão com o banco de dados.
                    conexao.Open();

                    //Cria um texto com os comandos a serem inseridos no script.
                    sql.Append("SELECT Produtos.*, NOME_CATEGORIA from Produtos INNER JOIN Categoria ON Produtos.ID_CATEGORIA = Categoria.ID_CATEGORIA");
                    sql.Append(" WHERE Produtos.NOME_PRODUTO LIKE '%'+@nome+'%'");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

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
    }
}
