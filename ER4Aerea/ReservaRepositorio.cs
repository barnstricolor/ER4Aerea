using System.Collections.Generic;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class ReservaRepositorio: Repositorio 
    {
        protected override string tabela() { return "RESERVA"; }
        protected override string colunaId() { return "ID_RESERVA"; }
        protected override string[] colunas()
        {             
            return new string[] {colunaId(),"ID_CLIENTE","ID_USUARIO","VAL_PRECO","QTD_ASSENTO","ID_VOO"}; 
        }
        //PROTECTED
        protected override void valuesMap(Dictionary<string, object> d, Dominio dominio)
        {
            Reserva reserva = (Reserva)dominio;
            d.Add("ID_RESERVA", reserva.id);
            d.Add("ID_CLIENTE", reserva.cliente.id);
            d.Add("ID_USUARIO", reserva.usuario.id);
            d.Add("VAL_PRECO", reserva.preco);
            d.Add("QTD_ASSENTO", reserva.assentos);
            d.Add("ID_VOO", reserva.voo.id);

        }
        protected override Dominio mapRow(OleDbDataReader dr)
        {
            //ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            //Cliente cliente = (Cliente)clienteRepositorio.obter(int.Parse(dr["ID_CLIENTE"].ToString()));
            //Cliente cliente = new Cliente("");
            //cliente.id = int.Parse(dr["ID_CLIENTE"].ToString());
//            VooRepositorio vooRepositorio = new VooRepositorio();
            //Voo voo = (Voo)vooRepositorio.obter(int.Parse(dr["ID_VOO"].ToString()));
            //voo.id = int.Parse(dr["ID_CLIENTE"].ToString());
            //UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            //Usuario usuario = (Usuario)usuarioRepositorio.obter(int.Parse(dr["ID_USUARIO"].ToString()));

            Reserva reserva = new Reserva(null, int.Parse(dr["QTD_ASSENTO"].ToString()), float.Parse(dr["VAL_PRECO"].ToString()), null, null);

            reserva.id = int.Parse(dr["ID_RESERVA"].ToString());

            return reserva;
        }
        public override object[] extrairValores(Dominio dominio)
        {
            Reserva reserva = (Reserva)dominio;
            return new object[] { reserva.id, reserva.cliente.id, reserva.usuario.id,reserva.preco,reserva.assentos,reserva.voo.id };
        }
        public override string montarWhereByFiltroString(string filtro){
            return "";
        }
        
        public HashSet<Reserva> obterByVoo(int idVoo)
        {
            OleDbDataReader dr = executeQuery(montarSelect("ID_VOO = " + idVoo.ToString()));

            HashSet<Reserva> lista = new HashSet<Reserva>();

            while (dr.Read())
            {
                lista.Add((Reserva)mapRow(dr));

            }

            return lista;
        }
    }
}
