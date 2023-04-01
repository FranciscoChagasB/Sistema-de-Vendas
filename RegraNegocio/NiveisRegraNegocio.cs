using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class NiveisRegraNegocio
    {
        AcessoDados.NiveisAcessoDados novoNivel;

        public void Validar(string nome, string descricao)
        //Método para validar se os campos estão preenchidos corretamente.
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Descrição não pode ser vazio!");
            }
        }

        public void Salvar(string nome, string descricao)
        //Método que irá salvar um novo nível de acordo com os dados recebidos da interface.
        {
            try
            {
                //Realiza a validação.
                Validar(nome, descricao);

                //Salva um novo nível no banco de dados acessando o método Salvar na camada AcessoDados.
                novoNivel = new AcessoDados.NiveisAcessoDados();
                novoNivel.Salvar(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idNivel, string nome, string descricao)
        //Método que irá selecionar um nível e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Realiza a validação.
                Validar(nome, descricao);

                //Altera um nível existente no banco de dados acessando o método Alterar na camada AcessoDados.
                novoNivel = new AcessoDados.NiveisAcessoDados();
                novoNivel.Alterar(idNivel, nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCategoria)
        //Método que irá selecionar um nível e excluí-lo do banco de dados.
        {
            try
            {
                //Exclui um nível existene no banco de dados acessando o método Excluir na camada AcessoDados.
                novoNivel = new AcessoDados.NiveisAcessoDados();
                novoNivel.Excluir(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        //Método que irá listar os níveis existente no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os niveis existentes no banco de dados acessando a camada AcessoDados.
                novoNivel = new AcessoDados.NiveisAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os níveis existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoNivel.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
