using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class UsuariosRegraNegocio
    {
        AcessoDados.UsuariosAcessoDados novoUsuario;
        Criptografia criptografar;

        public void Validar(string nome, string login, int idNivel, string senha, string senha2, string status)
        //Método para validar se os campos estão preenchidos corretamente.
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio");
            }

            if (login.Trim().Length == 0)
            {
                throw new Exception("O campo Login não pode ser vazio");
            }

            if (idNivel == 0)
            {
                throw new Exception("O campo Nível não pode ser vazio");
            }

            if (senha.Trim().Length == 0 && senha2.Trim().Length == 0)
            {
                throw new Exception("O campo Senha não pode ser vazio");
            }

            if (senha.Trim().Length > 8)
            {
                throw new Exception("O campo Senha não pode ter mais de 8 (oito) caracteres.");
            }

            if (senha != senha2)
            {
                throw new Exception("As senhas não conferem. Digite-as novamente.");
            }

            if (status.Trim().Length == -1)
            {
                throw new Exception("O campo Status não pode ser vazio");
            }

        }

        public void Salvar(string nome, DateTime data, string login, int idNivel, string senha, string senha2, string status)
        //Método que irá salvar um novo usuário de acordo com os dados recebidos da interface.
        {
            try
            {
                //Realiza a validação.
                Validar(nome, login, idNivel, senha, senha2, status);

                //Cria um DataTable que irá armazenar os logins existentes no bando de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login);

                //Verifica se não há nenhum usuário já cadastrado com o mesmo login informado.
                if (dadosTabela.Rows.Count > 0)
                {
                    throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuário: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                }
                //Caso não, Salva um novo usuário no banco de dados.
                else
                {
                    //Criptografa a senha para armazenar no banco acessando a clase Criptografia.

                    criptografar = new Criptografia();
                    string senhaCripto = criptografar.Criptografar(senha);

                    //Salva um novo nível no banco de dados acessando o método Salvar na camada AcessoDados.
                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Salvar(nome, data, login, idNivel, senhaCripto, status);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idUsuario, string nome, DateTime data, string login, int idNivel, string senha, string senha2, string status)
        //Método que irá selecionar um usuário e realizar alterações de acordo com os dados recebidos da interface.
        {
            try
            {
                //Realiza a validação.
                Validar(nome, login, idNivel, senha, senha2, status);

                //Cria um DataTable que irá armazenar os logins existentes no bando de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login);

                //Criptografa a senha para armazenar no banco acessando a clase Criptografia.

                criptografar = new Criptografia();
                string senhaCripto = criptografar.Criptografar(senha); //Criptografa a senha para armazenar no banco.

                //Verifica se há algum usuário cadastrado com o mesmo login informado.
                if (dadosTabela.Rows.Count > 0)
                {
                    //Cria um laço para percorrer todos usuário com o login informado.
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        //Verifica se o login informado para alterar não está sendo utilizado.
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_USUARIO"]) == idUsuario)
                        {
                            //Altera um usuário existente no banco de dados acessando o método Alterar na camada AcessoDados.
                            novoUsuario = new AcessoDados.UsuariosAcessoDados();
                            novoUsuario.Alterar(idUsuario, nome, data, login, idNivel, senhaCripto, status);
                        }
                        //Caso já esteja sendo utilizado, informa ao usuário para inserir outro.
                        else
                        {
                            throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuario: " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                        }
                    }
                }
                //Caso não, Altera um usuário do banco de dados.
                else
                {
                    //Altera um nível existente no banco de dados acessando o método Alterar na camada AcessoDados.
                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Alterar(idUsuario, nome, data, login, idNivel, senhaCripto, status);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idUsuario)
        //Método que irá selecionar um usuário e excluí-lo do banco de dados.
        {
            try
            {
                //Exclui um usuário existente no banco de dados acessando o método Excluir na camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                novoUsuario.Excluir(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        //Método que irá listar os usuários existente no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Lista os usuários existentes no banco de dados acessando o método Listar na camada AcessoDados.
                dadosTabela = novoUsuario.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Login(string login, string senha)
        //Método que irá verificar o login do usuário no banco de dados.
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna o usuário com o mesmos login e senha informados acessando o método Login na camada AcessoDados.
                dadosTabela = novoUsuario.Login(login, senha);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarUsuario(int idUsuario)
        //Método que irá retornar um usuário do banco de dados de acordo com o ID informado na interface
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna o usuário com o mesmo ID informado acessando o método RetornarUsuario na camada AcessoDados.
                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNome(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os usuários que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os usuários com o nome similar ao informado acessando o método PesquisaNome na camada AcessoDados.
                dadosTabela = novoUsuario.PesquisaNome(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaAtivos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os usuários ATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os usuários ATIVOS com o nome similar ao informado acessando o método PesquisaAtivos na camada AcessoDados.
                dadosTabela = novoUsuario.PesquisaAtivos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaInativos(string nome, string ordem) //Parâmetros a serem adicionados.
        //Método que irá retornar os usuários INATIVOS que informamos o nome, em ordem x que informamos.
        {
            try
            {
                //Cria o DataTable que irá armazenar os usuários existentes no banco de dados acessando a camada AcessoDados.
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                //Retorna os usuários INATIVOS com o nome similar ao informado acessando o método PesquisaInativos na camada AcessoDados.
                dadosTabela = novoUsuario.PesquisaInativos(nome, ordem); //Parâmetros indicados no método.
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
