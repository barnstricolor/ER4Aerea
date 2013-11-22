using System.Collections.Generic;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class UsuarioRepositorio: Repositorio 
    {
        protected override string tabela() { return "USUARIO"; }
        protected override string colunaId() { return "ID_USUARIO"; }
        protected override string[] colunas()
        {
            return new string[] { colunaId(), "NOM_USUARIO", "NOM_LOGIN", "NOM_SENHA", "NUM_CPF", "NOM_ENDERECO", "NUM_ENDERE", "ID_CIDADE"}; 
        }
        //PROTECTED
        protected override void valuesMap(Dictionary<string, object> d, Dominio dominio)
        {
            Usuario usuario = (Usuario)dominio;
            d.Add("ID_USUARIO", usuario.id);
            d.Add("NOM_USUARIO", usuario.nome);
            d.Add("NOM_LOGIN", usuario.login);
            d.Add("NOM_SENHA", usuario.senha);
            d.Add("NUM_CPF", usuario.cpf);
            d.Add("NOM_ENDERECO", usuario.endereco);
            d.Add("NUM_ENDERE", usuario.numero);
            d.Add("ID_CIDADE", usuario.cidade.id);
  
        }
        protected override Dominio mapRow(OleDbDataReader dr)
        {

            Usuario usuario = new Usuario();

            if (dr["ID_CIDADE"].ToString() != "")
            {
                CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
                Cidade cidade = (Cidade)cidadeRepositorio.obter(int.Parse(dr["ID_CIDADE"].ToString()));
                usuario.cidade = cidade;
            }

            usuario.id = int.Parse(dr["ID_USUARIO"].ToString());
            usuario.nome = dr["NOM_USUARIO"].ToString();
            usuario.login = dr["NOM_LOGIN"].ToString();
            usuario.senha = dr["NOM_SENHA"].ToString();
            usuario.cpf = dr["NUM_CPF"].ToString();
            usuario.endereco= dr["NOM_ENDERECO"].ToString();
            usuario.numero = int.Parse(dr["NUM_ENDERE"].ToString());

            return usuario;
        }
        public override object[] extrairValores(Dominio dominio)
        {
            Usuario usuario = (Usuario)dominio;
            return new object[] { usuario.id, usuario.nome, usuario.login, usuario.senha, usuario.cpf, usuario.endereco, usuario.numero, usuario.cidade };
        }
        public override string montarWhereByFiltroString(string filtro){
            return "NOM_USUARIO LIKE '%" + filtro + "%' OR NOM_LOGIN LIKE '%" + filtro + "%'";
        }
    }
}
