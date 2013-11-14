using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class AviaoRepositorio:Repositorio
    {
        protected override string tabela() { return "CAD_AVIAO"; }
        protected override string colunaId() { return "ID_AVIAO"; }
        protected override string[] colunas() {
            return new string[] { colunaId(), "NOM_MODELO", "QTD_ASSENTO" }; 
        }
        
        protected override Dominio mapRow(OleDbDataReader dr)
        {
            Aviao aviao = new Aviao(dr["NOM_MODELO"].ToString(), int.Parse(dr["QTD_ASSENTO"].ToString()));

            aviao.id = int.Parse(dr["ID_AVIAO"].ToString());
            aviao.modelo = dr["NOM_MODELO"].ToString();
            aviao.assentos = int.Parse(dr["QTD_ASSENTO"].ToString());

            return aviao;
        }

        protected override Dictionary<string, object> valuesMap(Dominio dominio)
        {
            Aviao aviao = (Aviao)dominio;
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("ID_AVIAO", aviao.id);
            d.Add("NOM_MODELO", aviao.modelo);
            d.Add("QTD_ASSENTO", aviao.assentos);

            return d;

        }
    }
}
