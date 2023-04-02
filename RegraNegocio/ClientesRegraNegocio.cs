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
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone,
                                   email, dataCadastro, nascimento, observacoes, status); //parametros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaFisica(int idCliente, string cpf, string rg) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaFisica(idCliente, cpf, rg); //Parâmetros indicados no método.

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.SalvarPessoaJuridica(idCliente, cnpj, ie); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaFisica(int idCliente) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.ListarPessoaFisica(idCliente); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaJuridica(int idCliente) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

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
        {
            try
            {
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
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaFisica(idCliente, cpf, rg); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.AlterarPessoaJuridica(idCliente, cnpj, ie); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCliente) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                novoCliente.Excluir(idCliente); //Parâmetros indicados no método.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNome(string nome) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaNome(nome); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCpf(string cpf) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaCpf(cpf); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCnpj(string cnpj) //Parâmetros a serem adicionados.
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisaCnpj(cnpj); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
