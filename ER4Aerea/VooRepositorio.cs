using System.Collections.Generic;
using System.Data.OleDb;
using System;

namespace ER4Aerea
{
    public class VooRepositorio: Repositorio 
    {
        protected override string tabela() { return "VOO"; }
        protected override string colunaId() { return "ID_VOO"; }
        protected override string[] colunas()
        {             
            return new string[] {colunaId(),"VAL_PRECO","ID_ORIGEM","ID_DESTINO","ID_AVIAO","DAT_PARTIDA","DAT_CHEGADA","FLG_PROMOCAO"}; 
        }
        
        protected override void valuesMap(Dictionary<string, object> d, Dominio dominio)
        {
            Voo voo = (Voo)dominio;
            d.Add("ID_VOO", voo.id);
            d.Add("VAL_PRECO", voo.preco);
            d.Add("ID_ORIGEM", voo.origem.id);
            d.Add("ID_DESTINO", voo.destino.id);
            d.Add("ID_AVIAO", voo.aviao.id);
            d.Add("DAT_PARTIDA", voo.partida);
            d.Add("DAT_CHEGADA", voo.chegada);
            d.Add("FLG_PROMOCAO", voo.promocao);

        }
        protected override Dominio mapRow(OleDbDataReader dr)
        {
            AviaoRepositorio aviaoRepositorio = new AviaoRepositorio();
            Aviao aviao = (Aviao)aviaoRepositorio.obter(int.Parse(dr["ID_AVIAO"].ToString()));
            CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
            Cidade origem = (Cidade)cidadeRepositorio.obter(int.Parse(dr["ID_ORIGEM"].ToString()));
            Cidade destino = (Cidade)cidadeRepositorio.obter(int.Parse(dr["ID_DESTINO"].ToString()));
            
            DateTime partida=DateTime.Parse(dr["DAT_PARTIDA"].ToString());
            float preco=float.Parse(dr["VAL_PRECO"].ToString());

            Voo voo = new Voo(aviao,origem,destino,partida,preco);
            voo.id = int.Parse(dr["ID_VOO"].ToString());
            voo.chegada = DateTime.Parse(dr["DAT_CHEGADA"].ToString());
            voo.promocao = dr["FLG_PROMOCAO"].ToString();

            ReservaRepositorio reservaRepositorio = new ReservaRepositorio();
            HashSet<Reserva> reservas = reservaRepositorio.obterByVoo(voo.id);
            //BUGSLIFE
            voo.reservas = reservas;
            //dr.Close();
            return voo;
        }
        public override object[] extrairValores(Dominio dominio)
        {
            Voo voo = (Voo)dominio;
            return new object[] { voo.id, voo.preco, voo.origem.id, voo.destino.id, voo.aviao.id,voo.partida};
        }
        public override string montarWhereByFiltroString(string filtro){
            return "";
        }
        protected override void afterSave(Dominio dominio) {

            ReservaRepositorio reservaRepositorio = new ReservaRepositorio();
            Voo voo=(Voo)dominio;
            foreach (Reserva reserva in voo.reservas) {
                if (reserva.id == 0)
                {
                    reserva.voo = voo;
                    reservaRepositorio.salvar(reserva);
                }
            }        
        }
    }
}
