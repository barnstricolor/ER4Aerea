using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ER4Aerea
{
    public abstract class Repositorio
    {
        private static Bd persistencia = Bd.Instance;
        
        protected abstract string tabela();
        protected abstract string colunaId();
        protected abstract string[] colunas();

        protected abstract Dominio mapRow(OleDbDataReader dr);
        protected abstract void valuesMap(Dictionary<string, object> d, Dominio dominio);

        protected Bd obterPersistencia()
        {
            return persistencia;
        }
        
        protected OleDbConnection obterConexao()
        {
            return this.obterPersistencia().obterConexao();
        }
        
        protected int obterSequencia()
        {
            return obterPersistencia().obterSequencia("SQ_" + tabela());
        }
        //PUBLIC
        public void excluir(int id)
        {
            string sql;

            OleDbConnection cnn = obterConexao();

            sql = "Delete " + tabela() + " Where " + colunaId() + " = ?";

            OleDbCommand cmd = new OleDbCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@" + colunaId(), id);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }
        public Dominio salvar(Dominio dominio)
        {
            if (dominio.id == 0)
            {
                return insert(dominio);
            }
            else
            {
                return update(dominio);
            }
        }
        public Dominio obter(int id)
        {

            OleDbDataReader dr = executeQueryById(id);

            if (!dr.HasRows) return null;

            dr.Read();

            return mapRow(dr);
        }
        //PRIVATE
        private Dominio insert(Dominio dominio)
        {

            dominio.id = obterSequencia();

            insertCommand(dominio);

            return dominio;
        }
        private Dominio update(Dominio dominio)
        {
            updateCommand(dominio, dominio.id);

            return dominio;
        }
        private Dictionary<string,object> criarDictionary(){
            return new Dictionary<string,object>();
        }

        protected string montarSelectWhereId(int id) {
            string str = "Select * from " + tabela() + " Where " + colunaId() +" = " + id.ToString();
            return str;
        }
        protected OleDbDataReader executeQuery(string str) {
            OleDbDataReader dr = this.obterPersistencia().obterQuery(str);
            return dr;
        }
        protected OleDbDataReader executeQueryById(int id)
        {
            return executeQuery(montarSelectWhereId(id));
        }
        protected string montarInsert()
        {   string[] strAux= new string[colunas().Length];

            for (int i = 0; i < colunas().Length; i++)
            {
                strAux[i] = "?";
            }
        
            string str = "Insert Into " + tabela() + "(" + string.Join(",", colunas()) + ")";
            str += " Values (" + string.Join(",", strAux) + ")";

            return str;
        }
        protected string montarUpdateById(int id)
        {
            string[] strAux = new string[colunas().Length];

            for (int i = 0; i < colunas().Length; i++)
            {
                strAux[i] = colunas()[i] +" = ?";
            }
            
            string str = "Update " + tabela() + " Set " + string.Join(",", strAux);            
            str += " Where " + colunaId() + " = " + id.ToString();

            return str;
        }
        protected void insertCommand(Dominio dominio)
        {
            executarCommand(montarInsert(),dominio);
        }
        
        protected void updateCommand(Dominio dominio,int id)
        {
            executarCommand(montarUpdateById(id),dominio);
        }

        protected void executarCommand(string cmdText, Dominio dominio){
            Dictionary<string,object> d = criarDictionary();
            valuesMap(d,dominio);
            montarCommand(cmdText,d).ExecuteNonQuery();
        }

        protected OleDbCommand montarCommand(string cmdText, Dictionary<string, object> d)
        {
            OleDbCommand cmd = new OleDbCommand(cmdText, obterConexao());
            foreach (var value in d)
                cmd.Parameters.AddWithValue("@" + value.Key, value.Value);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = cmdText;
            return cmd;
        }

    }
}
