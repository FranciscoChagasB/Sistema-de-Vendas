
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ProdutoRegraNegocio
    {
        AcessoDados.ProdutoAcessoDados novoProduto;

        public void SalvarCategoria(string nomeCategoria, string descricaoCategoria) //Parâmetros a serem adicionados.
        //Método que irá salvar uma nova categoria de acordo com os dados recebidos da interface.
        {
            try
            {
                //Salva uma nova categoria no banco de dados acessando o método SalvarCategoria na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.SalvarCategoria(nomeCategoria, descricaoCategoria); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarCategoria(int idCategoria, string nomeCategoria, string descricaoCategoria) //Parâmetros a serem adicionados.
        //Método que irá selecionar uma categoria e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera uma categoria existente no banco de dados acessando o método AlterarCategoria na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.AlterarCategoria(idCategoria, nomeCategoria, descricaoCategoria); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCategoria(int idCategoria) //Parâmetros a serem adicionados.
        //Método que irá selecionar uma categoria e excluí-la do banco de dados.
        {
            try
            {
                //Exclui uma cateogira existente no banco de dados acessando o método ExcluirCategoria na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.ExcluirCategoria(idCategoria); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarCategorias()
        //Método que irá listar as categorias existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar as categorias existentes no banco de dados acessando a camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista as categorias existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoProduto.ListarCategorias();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
