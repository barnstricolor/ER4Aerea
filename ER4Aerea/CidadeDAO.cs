using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ER4Aerea
{
    class CidadeDAO
    {
        Bd persistencia=new Bd();

        public Cidade salvar(Cidade cidade) {
            if (cidade.id == 0)
            {
                return insert(cidade);
            }
            else 
            {
                return update(cidade);
            }
        }

        public void excluir(Cidade cidade) {
            delete(cidade);
        }
        private Cidade insert(Cidade cidade) 
        {
            string sql; 
            
            OleDbConnection cnn=persistencia.obterConexao();
            
            sql = "Insert Into CAD_CIDADE (ID_CIDADE, NOM_CIDADE,NUM_CEP) Values (?, ?, ?)";
            
            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            cidade.id = persistencia.obterSequencia("SQ_CAD_CIDADE");

            cmd.Parameters.AddWithValue("@ID_CIDADE",cidade.id);
            cmd.Parameters.AddWithValue("@NOM_CIDADE", cidade.nome);
            cmd.Parameters.AddWithValue("@NUM_CEP", cidade.cep);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            return cidade;
        }
        private Cidade update(Cidade cidade)
        {
            string sql;

            OleDbConnection cnn = persistencia.obterConexao();

            sql = "Update CAD_CIDADE set NOM_CIDADE = ? ,NUM_CEP = ? Where ID_CIDADE = ?";

            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@NOM_CIDADE", cidade.nome);
            cmd.Parameters.AddWithValue("@NUM_CEP", cidade.cep);
            cmd.Parameters.AddWithValue("@ID_CIDADE", cidade.id);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            return cidade;
        }
        private void delete(Cidade cidade)
        {
            string sql;

            OleDbConnection cnn = persistencia.obterConexao();

            sql = "Delete CAD_CIDADE Where ID_CIDADE = ?";

            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@ID_CIDADE", cidade.id);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }

    }
}
