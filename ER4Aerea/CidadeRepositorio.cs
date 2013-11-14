﻿using System.Collections.Generic;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class CidadeRepositorio: Repositorio 
    {
        protected override string tabela() { return "CAD_CIDADE"; }
        protected override string colunaId() { return "ID_CIDADE"; }
        protected override string[] colunas() { 
            
            return new string[] {colunaId(),"NOM_CIDADE","NUM_CEP"}; 
        }

        //PROTECTED
        protected override Dictionary<string, object> valuesMap(Dominio dominio)
        {
            Cidade cidade = (Cidade)dominio;
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("ID_CIDADE", cidade.id);
            d.Add("NOM_CIDADE", cidade.nome);
            d.Add("NUM_CEP", cidade.cep);

            return d;
        }
        protected override Dominio mapRow(OleDbDataReader dr) {

            Cidade cidade = new Cidade(dr["NOM_CIDADE"].ToString());

            cidade.id = int.Parse(dr["ID_CIDADE"].ToString());
            cidade.nome = dr["NOM_CIDADE"].ToString();
            cidade.cep = dr["NUM_CEP"].ToString();

            return cidade;

        }
    }
}
