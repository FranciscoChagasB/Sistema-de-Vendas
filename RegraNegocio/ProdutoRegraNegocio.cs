
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

        public void SalvarUnidade(string nomeUnidade, string descricaoUnidade) //Parâmetros a serem adicionados.
        //Método que irá salvar uma nova unidade de acordo com os dados recebidos da interface.
        {
            try
            {
                //Salva uma nova unidade no banco de dados acessando o método SalvarUnidade na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.SalvarUnidade(nomeUnidade, descricaoUnidade); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarUnidade(int idUnidade, string nomeUnidade, string descricaoUnidade) //Parâmetros a serem adicionados.
        //Método que irá selecionar uma unidade e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera uma unidade existente no banco de dados acessando o método AlterarUnidade na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.AlterarUnidade(idUnidade, nomeUnidade, descricaoUnidade); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirUnidade(int idUnidade) //Parâmetros a serem adicionados.
        //Método que irá selecionar uma unidade e excluí-la do banco de dados.
        {
            try
            {
                //Exclui uma unidade existente no banco de dados acessando o método ExcluirUnidade na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.ExcluirUnidade(idUnidade); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarUnidades()
        //Método que irá listar as unidades existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar as unidades existentes no banco de dados acessando a camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista as unidades existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoProduto.ListarUnidades();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar(string codigoBarras, string nome, string descrição, int idUnidade, int idCategoria, int estoqueMinimo,
                           int estoqueAtual, string valorCompra, string valorVenda, string margem, string anotacoesProduto,
                           bool situacaoProdutos, DateTime dataCadastroProduto) //Parâmetros a serem adicionados.
        //Método que irá salvar um novo produto de acordo com os dados recebidos da interface.
        {
            try
            {
                Validar(codigoBarras, nome, descrição, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutoAcessoDados();

                DataTable dadosTabela = new DataTable();
                //Verifica se existem produtos cadastrados com o mesmo código de barras. Se existir(em), serão armazenados em dadosTabela.
                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);

                if (dadosTabela.Rows.Count > 0) //Verifica se a pesquisa retornou linhas. Se verdadeiro, o cadastro é interrompido.
                {
                    //Informa ao usuário que já existe um produto cadastrado, mostrando o nome dele.
                    throw new Exception("Já existe um produto cadastrado com esse código de barras! \n Produto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                }
                else
                {
                    //Salva um novo produto no banco de dados acessando o método Salvar na camada AcessoDados.
                    novoProduto = new AcessoDados.ProdutoAcessoDados();
                    novoProduto.Salvar(codigoBarras, nome, descrição, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra),
                                       Convert.ToDecimal(valorVenda), Convert.ToDecimal(margem), anotacoesProduto, situacaoProdutos, dataCadastroProduto); //Parâmetros indicados no método.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
                            string valorCompra, string valorVenda, string margem, string anotacoesProdutos, bool situacaoProdutos, DateTime dataCadastroProduto) //Parâmetros a serem adicionados.
        //Método que irá selecionar um produto e realizar alterações de acordo com os dados recebidos da interface.

        {
            try
            {
                Validar(codigoBarras, nome, descricao, idCategoria, estoqueAtual, estoqueMinimo, idUnidade, valorCompra, margem, valorVenda);

                novoProduto = new AcessoDados.ProdutoAcessoDados();

                DataTable dadosTabela = new DataTable();
                //Verifica se existem produtos cadastrados com o mesmo código de barras. Se existir(em), serão armazenados em dadosTabela.
                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);

                //Verifica se a pesquisa retornou linhas. Se sim, precisamos verificar se o retorno trata-se do produto que estamos alterando.
                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++) //Percorre cada linha da tabela em memória.
                    {
                        //Verifica se o conteúdo da coluna ID_PRODUTO presente na tabela é igual ao valor do parâmetro idProduto. Se for igual, altera.
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_PRODUTO"]) == idProduto)
                        {
                            //Altera uma unidade existente no banco de dados acessando o método AlterarUnidade na camada AcessoDados.
                            novoProduto = new AcessoDados.ProdutoAcessoDados();
                            novoProduto.Alterar(idProduto, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra), Convert.ToDecimal(valorVenda),
                                                Convert.ToDecimal(margem), anotacoesProdutos, situacaoProdutos, dataCadastroProduto); //Parâmetros indicados no método.
                        }
                        else //Caso contrário, trata-se de outro produto, portanto, não pode ser alterado.
                        {
                            //Informa ao usuário que já existe um produto cadastrado, mostrando o nome dele.
                            throw new Exception("Já existe um produto cadastrado com esse código de barras! \n Produto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                        }
                    }
                }
                else //Se não retornou linhas, significa que não existe nenhum código de barras igual a este cadastrado, portanto, pode ser alterado.
                {
                    //Altera uma unidade existente no banco de dados acessando o método AlterarUnidade na camada AcessoDados.
                    novoProduto = new AcessoDados.ProdutoAcessoDados();
                    novoProduto.Alterar(idProduto, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(valorCompra), Convert.ToDecimal(valorVenda),
                                        Convert.ToDecimal(margem), anotacoesProdutos, situacaoProdutos, dataCadastroProduto); //Parâmetros indicados no método.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idproduto) //Parâmetros a serem adicionados.
        //Método que irá selecionar um produto e excluí-lo do banco de dados.
        {
            try
            {
                //Exclui um produto existente no banco de dados acessando o método Excluir na camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.Excluir(idproduto); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        //Método que irá listar os produtos existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os produtos existentes no banco de dados acessando a camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os produtos existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoProduto.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validar(string codigoBarras, string nome, string descricao, int idCategoria, int estoqueAtual,
                            int estoqueMinimo, int idUnidade, string valorCompra, string margem, string valorVenda) //Parâmetros do método.
        //Método que irá Validar os campos de preenchimento do cadastro de produto.
        {
            if (codigoBarras.Trim().Length == 0)
            {
                throw new Exception("O campo Código de Barras deve ser preenchido!");
            }

            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Descrição não pode ser vazio!");
            }

            if (idCategoria == 0)
            {
                throw new Exception("O campo Categoria não pode ser vazio!");
            }

            if (estoqueAtual == 0)
            {
                throw new Exception("O campo Estoque Atual não pode ser vazio!");
            }

            if (estoqueMinimo == 0)
            {
                throw new Exception("O campo Estoque Mínimo não pode ser vazio!");
            }

            if (idUnidade == 0)
            {
                throw new Exception("O campo Unidade do Produto não pode ser vazio!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(valorCompra);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Custo.");
            }

            if (Convert.ToDecimal(valorCompra) == 0)
            {
                throw new Exception("O campo Custo não pode ser vazio!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(margem);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Margem de Lucro %.");
            }

            if (Convert.ToDecimal(margem) == 0)
            {
                throw new Exception("O campo Margem de Lucro % não pode ser vazio!");
            }

            if (Convert.ToDecimal(margem) >= 100)
            {
                throw new Exception("O campo Margem de Lucro % não pode ser maior ou igual a 100!");
            }


            try
            {
                decimal valor = Convert.ToDecimal(valorVenda);
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico no campo Venda.");
            }

            if (Convert.ToDecimal(valorVenda) == 0)
            {
                throw new Exception("O campo Venda não pode ser vazio!");
            }
        }

        public DataTable PesquisaNome(string nome)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.PesquisaNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable PesquisaCodigoBarras(string codigoBarras) //Parâmetros do método.
        //Método que irá Pesquisar um produto pelo código de barras.
        {
            try
            {
                //Cria o DataTable que irá armazenar os dados no banco de dados acessando a camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os produtos existentes no banco de dados acessando o método PesquisarCodigoBarras na camada AcessoDados.
                dadosTabela = novoProduto.PesquisaCodigoBarras(codigoBarras);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarProduto(string codigoBarras) //Parâmetros do método.
        //Método que irá Retornar o produto de acordo com o código de barras.
        {
            try
            {
                //Cria o DataTable que irá armazenar os dados no banco de dados acessando a camada AcessoDados.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista o produto existente no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoProduto.RetornarProduto(codigoBarras);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int RetornarEstoqueProduto(int idProduto) //Parâmetros do método.
        //Método que irá Retornar o estoque do produtos que informamos o id.
        {
            try
            {
                //Retorna um inteiro com a quantidade de produto em estoque.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                int quantidadeAtual = novoProduto.RetornarEstoqueProduto(idProduto);
                return quantidadeAtual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarEstoque(int idProduto, int estoqueAtual) //Parâmetros do método.
        //Método que irá Atualizar o estoque de acordo com o produto e quantidade que informamos.
        {
            try
            {
                //Atualiza o estoque do produto.
                novoProduto = new AcessoDados.ProdutoAcessoDados();
                novoProduto.AtualizarEstoque(idProduto, estoqueAtual);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
