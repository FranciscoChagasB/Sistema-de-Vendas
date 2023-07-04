using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class FuncionariosRegraNegocio
    {
        AcessoDados.FuncionariosAcessoDados novoFuncionario;
        public void Salvar(string nome, string cpf, string rg, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //Parâmetros a serem adicionados.
        //Método que irá salvar um novo funcionário de acordo com os dados recebidos da interface.
        {
            try
            {
                //Salva um novo funcionário no banco de dados acessando o método Salvar na camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Salvar(nome, cpf, rg, endereco, bairro, cep, cidade, estado, telefone,
                                   email, dataCadastro, nascimento, observacoes, status); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        //Método que irá listar os funcionários existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os funcionários existentes no banco de dados acessando a camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os funcionários existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoFuncionario.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idFuncionario, string nome, string cpf, string rg, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //Parâmetros a serem adicionados.
        //Método que irá selecionar um funcionário e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera um funcionário existente no banco de dados acessando o método Alterar na camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Alterar(idFuncionario, nome, endereco, bairro, cep, cidade, estado, telefone,
                                        rg, cpf, email, dataCadastro, nascimento, observacoes, status); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idFuncionario) //Parâmetros a serem adicionados.
        //Método que irá selecionar um funcionário e excluí-lo do banco de dados.
        {
            try
            {
                //Exclui um funcionário existente no banco de dados acessando o método Excluir na camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                novoFuncionario.Excluir(idFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarNome(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os funcionários que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os funcionários existentes no banco de dados acessando a camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os funcionários com o nome similar ao informado acessando o método PesquisaNome na camada AcessoDados.
                dadosTabela = novoFuncionario.PesquisarNome(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaAtivos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os funcionários ATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os funcionários ativos existentes no banco de dados acessando a camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os funcionários com o nome similar ao informado acessando o método PesquisaAtivos na camada AcessoDados.
                dadosTabela = novoFuncionario.PesquisaAtivos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaInativos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os funcionários INATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os funcionários inativos existentes no banco de dados acessando a camada AcessoDados.
                novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os funcionários com o nome similar ao informado acessando o método PesquisaInativos na camada AcessoDados.
                dadosTabela = novoFuncionario.PesquisaInativos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
