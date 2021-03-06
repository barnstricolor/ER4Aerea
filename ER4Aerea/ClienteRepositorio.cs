﻿using System.Collections.Generic;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class ClienteRepositorio: Repositorio 
    {
        protected override string tabela() { return "CLIENTE"; }
        protected override string colunaId() { return "ID_CLIENTE"; }
        protected override string[] colunas()
        {             
            return new string[] {colunaId(),"NOM_CLIENTE","FLG_PROMOCAO","NOM_EMAIL","NOM_ENDERECO", "NUM_CPF", "NUM_CELULAR", "VAL_RENDA", "NOM_OCUPACAO", "FLG_ESPECIAL", "NUM_RG", "SEXO", "NUM_END", "NOM_BAIRRO", "CAD_CEP", "NUM_TELEFONE","ID_CIDADE","PER_DESCONTO"}; 
        }
        //PROTECTED
        protected override void valuesMap(Dictionary<string, object> d, Dominio dominio)
        {
            Cliente cliente = (Cliente)dominio;
            d.Add("ID_CLIENTE", cliente.id);
            d.Add("NOM_CLIENTE", cliente.nome);
            d.Add("FLG_PROMOCAO", cliente.promocao);
            d.Add("NOM_EMAIL", cliente.email);
            d.Add("NOM_ENDERECO", cliente.endereco);
            d.Add("NUM_CPF", cliente.cpf);
            d.Add("NUM_CELULAR", cliente.celular);
            d.Add("VAL_RENDA", cliente.renda);
            d.Add("NOM_OCUPACAO", cliente.ocupacao);
            d.Add("FLG_ESPECIAL", cliente.especial);
            d.Add("NUM_RG", cliente.rg);
            d.Add("SEXO", cliente.sexo);
            d.Add("NUM_END", cliente.endereco);
            d.Add("NOM_BAIRRO", cliente.bairro);
            d.Add("CAD_CEP", cliente.cep);
            d.Add("NUM_TELEFONE", cliente.telefone);
            d.Add("ID_CIDADE", cliente.cidade.id);
            d.Add("PER_DESCONTO", cliente.desconto);

        }
        protected override Dominio mapRow(OleDbDataReader dr)
        {

            Cliente cliente = new Cliente(dr["NOM_CLIENTE"].ToString());
            if (dr["ID_CIDADE"].ToString() != "")
            {
                //CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
                Cidade cidade = new Cidade("","");//(Cidade)cidadeRepositorio.obter(int.Parse(dr["ID_CIDADE"].ToString()));
                cidade.id = int.Parse(dr["ID_CIDADE"].ToString());
                cliente.cidade = cidade;
            }

            cliente.id = int.Parse(dr["ID_CLIENTE"].ToString());
            cliente.nome = dr["NOM_CLIENTE"].ToString();
            cliente.promocao = dr["FLG_PROMOCAO"].ToString();
            cliente.email = dr["NOM_EMAIL"].ToString();
            cliente.endereco = dr["NOM_ENDERECO"].ToString();
            cliente.cpf = dr["NUM_CPF"].ToString();
            cliente.celular = dr["NUM_CELULAR"].ToString();
            cliente.renda = float.Parse(dr["VAL_RENDA"].ToString());
            cliente.ocupacao = dr["NOM_OCUPACAO"].ToString();
            cliente.promocao = dr["FLG_ESPECIAL"].ToString();
            cliente.rg = dr["NUM_RG"].ToString();
            cliente.sexo = dr["SEXO"].ToString();
            cliente.numero = dr["NUM_END"].ToString();
            cliente.bairro = dr["NOM_BAIRRO"].ToString();
            cliente.cep = dr["CAD_CEP"].ToString();
            cliente.telefone = dr["NUM_TELEFONE"].ToString();
            cliente.especial = dr["FLG_ESPECIAL"].ToString();
            cliente.desconto = float.Parse(dr["PER_DESCONTO"].ToString());
            //dr.Close();
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
        public HashSet<Dominio> obterPromocao()
        {
            OleDbDataReader dr = executeQuery(montarSelect("FLG_PROMOCAO = 'S' And NOM_EMAIL IS NOT NULL"));

            HashSet<Dominio> lista = new HashSet<Dominio>();

            while (dr.Read())
            {
                lista.Add(mapRow(dr));
            }
            dr.Close();

            return lista;
        }

    }
}
