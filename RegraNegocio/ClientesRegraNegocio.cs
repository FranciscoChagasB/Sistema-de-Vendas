using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ClientesRegraNegocio
    {
        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();
        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //Parâmetros a serem adicionados.
        //Método que irá salvar um novo cliente de acordo com os dados recebidos da interface.
        {
            try
            {
                //Salva um novo cliente no banco de dados acessando o método Salvar na camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone,
                                   email, dataCadastro, nascimento, observacoes, status); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaFisica(int idCliente, string cpf, string rg) //Parâmetros a serem adicionados.
        //Método que irá salvar um cliente que foi cadastrado como pessoa física.
        {
            try
            {
                //Salva um novo cliente do tipo pessoa física.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaFisica(idCliente, cpf, rg); //Parâmetros indicados no método.

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie) //Parâmetros a serem adicionados.
        //Método que irá salvar um cliente que foi cadastrado como pessoa jurídica.
        {
            try
            {
                //Salva um novo cliente do tipo pessoa jurídica.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaJuridica(idCliente, cnpj, ie); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        //Método que irá listar os clientes existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os clientes existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoCliente.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaFisica(int idCliente) //Parâmetros a serem adicionados.
        //Método que irá listar os clientes do tipo pessoa física existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes do tipo pessoa física existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os clientes do tipo pessoa física existentes no banco de dados acessando o método ListarPessoaFisica na camada AcessoDados.
                dadosTabela = novoCliente.ListarPessoaFisica(idCliente); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaJuridica(int idCliente) //Parâmetros a serem adicionados.
        //Método que irá listar os clientes do tipo pessoa jurídica existentes no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes do tipo pessoa jurídica existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os clientes do tipo pessoa jurídica existentes no banco de dados acessando o método ListarPessoaJuridica na camada AcessoDados.
                dadosTabela = novoCliente.ListarPessoaJuridica(idCliente); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone,
                           string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string status) //Parâmetros a serem adicionados.
        //Método que irá selecionar um cliente e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera um cliente existente no banco de dados acessando o método Alterar na camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone,
                                   email, dataCadastro, nascimento, observacoes, status); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarPessoaFisica(int idCliente, string cpf, string rg) //Parâmetros a serem adicionados.
        //Método que irá selecionar um cliente na tabela Pessoa_fisica e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera uma pessoa física existente no banco de dados acessando o método AlterarPessoaFisica na camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaFisica(idCliente, cpf, rg); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie) //Parâmetros a serem adicionados.
        //Método que irá selecionar um cliente na tabela Pessoa_juridica e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Altera uma pessoa jurídica existente no banco de dados acessando o método AlterarPessoaJuridica na camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaJuridica(idCliente, cnpj, ie); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCliente) //Parâmetros a serem adicionados.
        //Método que irá selecionar um cliente e excluí-lo do banco de dados.
        {
            try
            {
                //Exclui um cliente existente no banco de dados acessando o método Excluir na camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Excluir(idCliente); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNome(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaNome na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaNome(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCpf(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes CADASTRADOS COM CPF que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes cadastrados com cpf existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaCpf na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaCpf(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCpf(string nome) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes CADASTRADOS COM CPF que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes cadastrados com cpf existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaCpf na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaCpf(nome); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCnpj(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes CADASTRADOS COM CNPJ que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes cadastrados com cnpj existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaCnpj na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaCnpj(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCnpj(string nome) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes CADASTRADOS COM CNPJ que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes cadastrados com cnpj existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaCnpj na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaCnpj(nome); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaAtivos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes ATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes ativos existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaAtivos na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaAtivos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaInativos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os clientes INATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os clientes inativos existentes no banco de dados acessando a camada AcessoDados.
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os clientes com o nome similar ao informado acessando o método PesquisaInativos na camada AcessoDados.
                dadosTabela = novoCliente.PesquisaInativos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
