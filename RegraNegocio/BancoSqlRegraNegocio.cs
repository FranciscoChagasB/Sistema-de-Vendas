using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class BancoSqlRegraNegocio
    {
        AcessoDados.BancoSqlAcessoDados novoBanco;

        public DataTable VerificarBanco()
        {
            try
            {
                novoBanco = new AcessoDados.BancoSqlAcessoDados();
                return novoBanco.VerificarBanco();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CriaBanco()
        {
            try
            {
                string caminhoScriptBanco = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptBancoConstrucao.sql";
                FileInfo arquivoBanco = new FileInfo(caminhoScriptBanco);
                string scriptBancoAjustado = arquivoBanco.OpenText().ReadToEnd().Replace("GO", "");

                string caminhoScriptTabelas = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptTabelasConstrucao.sql";
                FileInfo arquivoTabelas = new FileInfo(caminhoScriptTabelas);
                string scriptTabelasAjustado = arquivoTabelas.OpenText().ReadToEnd().Replace("GO", "").Replace("CAR", "CARGO").Replace("Car", "Cargo").Replace("CATERIA", "CATEGORIA").Replace("Cateria", "Categoria").Replace("CODI", "CODIGO");

                novoBanco = new AcessoDados.BancoSqlAcessoDados();
                novoBanco.CriarBanco(scriptBancoAjustado, scriptTabelasAjustado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CriaNiveis()
        {
            try
            {
                novoBanco = new AcessoDados.BancoSqlAcessoDados();
                novoBanco.CriarNiveis();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CriaUsuario()
        {
            try
            {
                novoBanco = new AcessoDados.BancoSqlAcessoDados();
                novoBanco.CriarUsuario();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
