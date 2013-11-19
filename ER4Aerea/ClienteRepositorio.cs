using System.Collections.Generic;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class ClienteRepositorio: Repositorio 
    {
        protected override string tabela() { return "CLIENTE"; }
        protected override string colunaId() { return "ID_CLIENTE"; }
        protected override string[] colunas()
        {             
            return new string[] {colunaId(),"NOM_CLIENTE"}; 
        }
        //PROTECTED
        protected override void valuesMap(Dictionary<string, object> d, Dominio dominio)
        {
            Cliente cliente = (Cliente)dominio;
            d.Add("ID_CLIENTE", cliente.id);
            d.Add("NOM_CLIENTE", cliente.nome);

        }
        protected override Dominio mapRow(OleDbDataReader dr)
        {

            Cliente cliente = new Cliente(dr["NOM_CLIENTE"].ToString(), false);

            cliente.id = int.Parse(dr["ID_CLIENTE"].ToString());
            cliente.nome = dr["NOM_CLIENTE"].ToString();

            return cliente;
        }
        public override object[] extrairValores(Dominio dominio)
        {
            Cliente cliente = (Cliente)dominio;
            return new object[] { cliente.id, cliente.nome};
        }
        public override string montarWhereByFiltroString(string filtro){
            return "NOM_CLIENTE LIKE '%" + filtro + "%'";
        }
    }
}
