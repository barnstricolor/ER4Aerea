using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ER4Aerea
{
    class AviaoDAO
    {
        Bd persistencia = new Bd();

        public Aviao salvar(Aviao Aviao)
        {
            if (Aviao.id == 0)
            {
                return insert(Aviao);
            }
            else
            {
                return update(Aviao);
            }
        }

        private Aviao insert(Aviao Aviao)
        {
            string sql;

            OleDbConnection cnn = persistencia.obterConexao();

            sql = "Insert Into CAD_Aviao (ID_AVIAO, NOM_MODELO,QTD_ASSENTO) Values (?, ?, ?)";

            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            Aviao.id = persistencia.obterSequencia("SQ_CAD_AVIAO");

            cmd.Parameters.AddWithValue("@ID_AVIAO", Aviao.id);
            cmd.Parameters.AddWithValue("@NOM_MODELO", Aviao.modelo);
            cmd.Parameters.AddWithValue("@QTD_ASSENTO", Aviao.assentos);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            return Aviao;
        }
        private Aviao update(Aviao Aviao)
        {
            return Aviao;
        }
        private Aviao delete(Aviao Aviao)
        {
            return Aviao;
        }


    }
}
